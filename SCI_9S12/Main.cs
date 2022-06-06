/*
 * Author: Xiaobin Zhu
 * Project: serial port data receiver for 9S12
 * history:
 *      May 31, 2022 creat project. (UI, serial port connection, MySQL connection, export to txt file.)
 *      Jun 01, 2022 finished upload to MySQL
 *      Jun 02, 2022 add database table, field selection, data separator selection. 
 *                   In SaveToMySQL mode, add data varidation and manipulation. Update UI,and functionality test.
 *      Jun 04, 2022 fix bugs, add monitor function
 *      Jun 05, 2022 construct monitor function(port config)
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Diagnostics.Trace;

//add additional references
using System.IO;
using System.IO.Ports;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;


namespace SCI_9S12
{
    public partial class Main : Form
    {
        #region Declaration and fields

        //port and data        
        SerialPort _newSerialPort = null;
        string _dataIn = "";
        int _dataCounter = 0;
        bool IsCaptureData = false;
        int ReadMode = 0;
        string ReadTo_Parameter;

        //Use to carry all the Info about the current serial port
        public SerialPortPackage CurrentSerialPortPackage = new SerialPortPackage();

        //file IO
        StreamWriter _streamWriter = null;
        string FullFilePath;

        //MySQL
        MySqlConnection _mysql_conn = null;
        DatabaseInfo _dbInfo;
        char _dataSepatator;

        //monitor
        public Monitor Monitor_Page = null;
        #endregion

        /// <summary>
        /// Create Main form instance
        /// </summary>
        public Main()
        {
            InitializeComponent();

            //set app display in center screen
            StartPosition = FormStartPosition.CenterScreen;

            #region Events
            //main form events
            Load += Main_Load;
            menu_monitor.Click += Menu_monitor_Click;

            //com port control events
            menu_comcontrol_connect.Click += Menu_comcontrol_connect_Click;
            menu_comcontrol_disconnect.Click += Menu_comcontrol_disconnect_Click;
            btn_receivepause.Click += Btn_receivepause_Click;
            btn_refreshcom.Click += Btn_refreshcom_Click;
            comboBox_readmode.SelectedIndexChanged += ComboBox_readmode_SelectedIndexChanged;

            //file events
            menu_file_savetotxt.Click += Menu_file_savetotxt_Click;
            menu_file_savetotxt.CheckStateChanged += Menu_file_savetotxt_CheckStateChanged;
            menu_file_savetomysql.Click += Menu_file_savetomysql_Click;
            menu_file_savetomysql.CheckStateChanged += Menu_file_savetomysql_CheckStateChanged;
            menu_file_close.Click += (sender, e) => { Application.Exit(); };       //close APP
            menu_about.Click += (sender, e) => { new Help_Page().ShowDialog(); };  //show the help doc
            menuStrip_menu.MouseDown += MenuStrip_menu_MouseDown;


            //data control
            comboBox_dataseparator.SelectedIndexChanged += ComboBox_dataseparator_SelectedIndexChanged;
            #endregion

        }

        #region Event handlers

        /// <summary>
        /// Initialize UI when load the form
        /// </summary>
        private void Main_Load(object sender, EventArgs e)
        {
            //get the avariable serial port
            string[] PortList = SerialPort.GetPortNames();
            comboBox_comport.Items.AddRange(PortList);
            comboBox_comport.SelectedIndex = 0;

            //initialize baud rate, set default 9600
            string[] BaudRateList = { "75", "110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400" };
            comboBox_baudrate.Items.AddRange(BaudRateList);
            comboBox_baudrate.SelectedIndex = 7;

            //initialize read mode, set default readline
            string[] ReadMode = { "Read Line", "Read To" };
            comboBox_readmode.Items.AddRange(ReadMode);
            comboBox_readmode.SelectedIndex = 0;
            txt_readmode_readto.Visible = false;

            //default seting for serial port
            comboBox_options_parity.SelectedIndex = 0;
            comboBox_options_databits.SelectedIndex = 3;
            comboBox__options_stopbits.SelectedIndex = 0;

            //disable data control section
            groupBox_datacontrol.Enabled = false;
            btn_receivepause.Enabled = false;
        }

        /// <summary>
        /// Refresh com port list
        /// </summary>
        private void Btn_refreshcom_Click(object sender, EventArgs e)
        {
            //get the avariable serial port (refresh)
            string[] PortList = SerialPort.GetPortNames();
            comboBox_comport.Items.Clear();
            comboBox_comport.Items.AddRange(PortList);
            comboBox_comport.SelectedIndex = 0;
        }

        /// <summary>
        /// Change the read mode
        /// </summary>
        private void ComboBox_readmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //enable/disable the input for "read to" mode
            txt_readmode_readto.Visible = comboBox_readmode.SelectedIndex == 1;
        }

        /// <summary>
        /// Operation after receiving data
        /// </summary>
        private void _newSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //read the data base on the selection of read mode
            switch (ReadMode)
            {
                //read line (data end with line feed)
                case 0:
                    _dataIn = _newSerialPort.ReadLine();
                    break;
                case 1:
                    _dataIn = _newSerialPort.ReadTo(ReadTo_Parameter);
                    break;
            }

            //retrieve data from current port
            //_dataIn = _newSerialPort.ReadExisting();
            WriteLine(_dataIn);

            //discard received data if not intend to save
            if (!IsCaptureData)
            {
                _dataCounter = 0;
                return;
            }

            //base on data control format to construct parameter part of data
            string Query_Parameters = "";
            if (menu_file_savetomysql.Checked)
            {
                if (_dbInfo.FieldCount == 1)
                    Query_Parameters = $"'{_dataIn}'";
                else
                {
                    //create data parameter for query
                    string[] _dataList = _dataIn.Split(_dataSepatator);
                    //verify the selected separator match the received data 
                    if (_dataList.Length != _dbInfo.FieldCount)
                    {
                        MessageBox.Show("Error: Invalid Data Separator! Fail to match the data field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //reset the operation button, and receive flag
                        //Invoke(new Action());
                        Invoke(new Action(() => { Reset_btn_receivepause(); comboBox_dataseparator.Enabled = true; comboBox_dataseparator.SelectedIndex = 0; }));
                        return;
                    }

                    //varidation pass.
                    for (int i = 0; i < _dataList.Length; ++i)
                    {
                        if (i == _dataList.Length - 1)
                        {
                            Query_Parameters += $"'{_dataList[i]}'";
                            break;
                        }

                        Query_Parameters += $"'{_dataList[i]}',";
                    }
                }
            }

            //Update UI
            _dataCounter = _dataCounter == 100 ? 0 : _dataCounter + 10;  //Use to indicate receiving data.
            Invoke(new Action(() => { progressBar_saving.Value = _dataCounter; }));  //indicate receiving data

            //Take action
            //save data control(base on user selection)
            SaveReceivedData(Query_Parameters);

        }

        /// <summary>
        /// Selection to save data into local txt file
        /// </summary>
        private void Menu_file_savetotxt_Click(object sender, EventArgs e)
        {
            //cancel SaveToTxt option
            if (menu_file_savetotxt.Checked)
            {
                //reset UI and return
                FullFilePath = "N/A";
                menu_file_savetotxt.Checked = false;
                progressBar_savetotxt.Value = 0;

                //check other saving option before turn off saving data
                if (!menu_file_savetomysql.Checked)
                {
                    //reset operation button
                    Reset_btn_receivepause();
                    progressBar_saving.Value = 0;
                }
                return;
            }

            //create a savefiledialog
            SaveFileDialog _newSaveFileDialog = new SaveFileDialog();
            _newSaveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            //open a filedialog to select the save path
            if (_newSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //get the full path
                FullFilePath = _newSaveFileDialog.FileName;
                //update the UI
                menu_file_savetotxt.Checked = true;
                progressBar_savetotxt.Value = 100;

                //enable saving data button if connection created
                if (_newSerialPort != null && _newSerialPort.IsOpen)
                    btn_receivepause.Enabled = true;
            }

        }

        /// <summary>
        /// Selection to save data to online MySQL database(collect database config information, and connection test)
        /// </summary>
        private void Menu_file_savetomysql_Click(object sender, EventArgs e)
        {
            //cancel MySQL option
            if (menu_file_savetomysql.Checked)
            {
                //reset 
                menu_file_savetomysql.Checked = false;
                progressBar_savetomysql.Value = 0;
                groupBox_datacontrol.Enabled = false;

                if (!menu_file_savetotxt.Checked)
                {
                    //reset operation button
                    Reset_btn_receivepause();
                    progressBar_saving.Value = 0;
                }
                return;
            }


            //open MySQL connection form to input the information
            MySQL_Login _mysqlLoginPage = new MySQL_Login(Location);   //pass the main form location to relocate the dialog form
            _mysqlLoginPage.ShowDialog();
            //after submit connnection configure information, get the database parameters
            _dbInfo = _mysqlLoginPage._mysqlInfo;

            //check the request(Cancel/Connect)
            if (_dbInfo.Request == "Cancel")
                return;

            //connection is good, update the UI, enable data control section
            groupBox_datacontrol.Enabled = true;
            txt_fieldsCount.Text = _dbInfo.FieldCount.ToString();
            txt_fieldsname.Text = _dbInfo.FieldsOfDatabase;
            comboBox_dataseparator.Enabled = true;
            comboBox_dataseparator.SelectedIndex = 0;

            //no need to select separator if only select one data field 
            if (_dbInfo.FieldCount == 1)
            {
                menu_file_savetomysql.Checked = true;
                comboBox_dataseparator.Enabled = false;
                txt_dataexample.Text = _dbInfo.FieldsOfDatabase;

                //also check the connection. if connected, enable receivepause button
                if (_newSerialPort != null && _newSerialPort.IsOpen)
                    btn_receivepause.Enabled = true;
            }
        }

        /// <summary>
        /// Update the CurrentSerialPortPackage information of SaveToTxt option 
        /// </summary>
        private void Menu_file_savetotxt_CheckStateChanged(object sender, EventArgs e)
        {
            CurrentSerialPortPackage.IsSaveToTXT = menu_file_savetotxt.Checked;
            CurrentSerialPortPackage.TxtPath = FullFilePath;
            OutputConfigStatusUpdate();
        }

        /// <summary>
        /// Update the CurrentSerialPortPackage information  of SaveToMySQL option 
        /// </summary>
        private void Menu_file_savetomysql_CheckStateChanged(object sender, EventArgs e)
        {
            CurrentSerialPortPackage.IsSaveToMySQL = menu_file_savetomysql.Checked;
            OutputConfigStatusUpdate();
        }

        /// <summary>
        /// Create serial port connection 
        /// </summary>
        private void Menu_comcontrol_connect_Click(object sender, EventArgs e)
        {

            //setting validation
            if (comboBox_comport.SelectedIndex == -1 || comboBox_baudrate.SelectedIndex == -1 || comboBox_readmode.SelectedIndex == -1
                || (comboBox_readmode.SelectedIndex == 1 && txt_readmode_readto.Text.Trim() == ""))
            {
                //pop up error message
                MessageBox.Show("Error: Invalid Serial Port Control setting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //retrieve setting
            string Port = comboBox_comport.Text;
            int BaudRate = int.Parse(comboBox_baudrate.Text);
            Parity DataParity = (Parity)comboBox_options_parity.SelectedIndex;
            int Databits = int.Parse(comboBox_options_databits.Text);
            StopBits DataStopBits = (StopBits)(comboBox__options_stopbits.SelectedIndex + 1);
            ReadMode = comboBox_readmode.SelectedIndex;
            ReadTo_Parameter = txt_readmode_readto.Text;

            //build connection and open
            _newSerialPort = new SerialPort(Port, BaudRate, DataParity, Databits, DataStopBits);

            //handle exception
            try
            {
                //open the current port
                _newSerialPort.Open();

                //assigned the valid port to the serial port package fields
                CurrentSerialPortPackage._SerialPort = _newSerialPort;
                //trigger updata event
                PortStatusUpdate();
                //limit the port related setting
                PortRelatedContols(false);


                //enable saving data button if already select saving option
                if (menu_file_savetotxt.Checked || (menu_file_savetomysql.Checked && (comboBox_dataseparator.SelectedIndex != 0 || _dbInfo.FieldCount == 1)))
                    btn_receivepause.Enabled = true;
            }
            catch (Exception ex)
            {
                //pop up error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //serial port event
            _newSerialPort.DataReceived += _newSerialPort_DataReceived;
        }

        /// <summary>
        /// Disconnect the current serial port communication
        /// </summary>
        private void Menu_comcontrol_disconnect_Click(object sender, EventArgs e)
        {
            //exit, if serialport instance does not exists
            if (_newSerialPort == null)
                return;

            if (_newSerialPort.IsOpen)
            {
                //close the current port 
                _newSerialPort.Close();
                //clear the serial port 
                _newSerialPort = null;

                //trigger updata event
                PortStatusUpdate();

                //Release the port related setting
                PortRelatedContols(true);

                //reset the save method to default
                menu_file_savetotxt.Checked = false;
                menu_file_savetomysql.Checked = false;

                //reset the indicators
                progressBar_saving.Value = 0;
                progressBar_savetotxt.Value = 0;
                progressBar_savetomysql.Value = 0;
                progressBar_uploading.Value = 0;

                //saving data control
                Reset_btn_receivepause();
            }
        }

        /// <summary>
        /// Change separator of the received data
        /// </summary>
        private void ComboBox_dataseparator_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear the example
            if (comboBox_dataseparator.SelectedIndex == 0)
            {
                menu_file_savetomysql.Checked = false;    //if no valid data separator, stop upload to mysql
                progressBar_savetomysql.Value = 0;
                txt_dataexample.Text = "";
                return;
            }

            menu_file_savetomysql.Checked = true;      //save to mysql option enable 
            progressBar_savetomysql.Value = 100;

            //show data example
            string Separator = comboBox_dataseparator.Text;
            _dataSepatator = Separator[0];
            string ExampleWithFields = _dbInfo.FieldsOfDatabase;
            txt_dataexample.Text = ExampleWithFields.Replace(",", Separator);

            //enable saving data button if connection created
            if (_newSerialPort != null && _newSerialPort.IsOpen)
            {
                btn_receivepause.Enabled = true;
            }


        }

        /// <summary>
        /// Enable/Disable saving data
        /// </summary>
        private void Btn_receivepause_Click(object sender, EventArgs e)
        {
            //Turn off saving data
            if (IsCaptureData)
            {
                IsCaptureData = false;
                btn_receivepause.Text = "Pausing...";
                progressBar_saving.Value = 0;
                progressBar_uploading.Value = 0;
                btn_refreshcom.Enabled = true;

                //data control option if select to save to mysql
                if (menu_file_savetomysql.Checked && _dbInfo.FieldCount != 1)
                    comboBox_dataseparator.Enabled = true;

            }
            //Turn on saving data
            else
            {
                IsCaptureData = true;
                btn_receivepause.Text = "Running...";
                btn_refreshcom.Enabled = false;

                //data control option if select to save to mysql
                if (menu_file_savetomysql.Checked)
                    comboBox_dataseparator.Enabled = false;
            }
        }

        /// <summary>
        /// Open live monitor page
        /// </summary>
        private void Menu_monitor_Click(object sender, EventArgs e)
        {
            if (Monitor_Page != null)
                return;

            Monitor_Page = new Monitor(this);
            Monitor_Page.Show();
        }


        #endregion

        #region Custom event handler 

        //create a custom delegate
        public delegate void UpdateDelegate();
        //declare an event method, return type is custom delegate
        public event UpdateDelegate UpdatePortconfigEventhandler;
        public event UpdateDelegate UpdateOutputconfigEventhandler;

        //event trigger methods
        protected void PortStatusUpdate()
        {
            //Invoke if event has been subscribed, otherwise, return
            UpdatePortconfigEventhandler?.Invoke();
        }

        protected void OutputConfigStatusUpdate()
        {
            //Invoke if event has been subscribed, otherwise, return
            UpdateOutputconfigEventhandler?.Invoke();
        }

        #endregion

        #region Helper methods

        /// <summary>
        /// Control of saving received data
        /// </summary>
        private void SaveReceivedData(string dataForDatabase)
        {
            //base on the selection to save the data
            //option 1: local txt file
            if (menu_file_savetotxt.Checked)
                SaveDataToTxt();

            //option 2: Online MySQL database
            if (menu_file_savetomysql.Checked)
                SaveDataToMySQL(dataForDatabase);

            //add more as need
        }

        /// <summary>
        /// Save data to MySQL
        /// </summary>
        private void SaveDataToMySQL(string paramters)
        {
            //indicator
            Invoke(new Action(() => { progressBar_uploading.Value = 0; }));

            //the MySQL Configure info has been verified and tested in info-collection part.
            //Connection should be good.
            try
            {
                //create connection to mysql
                using (_mysql_conn = new MySqlConnection(_dbInfo.ConnectiongString))
                {
                    //open connection
                    _mysql_conn.Open();

                    //database opertation part                     
                    string InsertQuery = $"INSERT INTO `{_dbInfo.TableName}`({_dbInfo.FieldsOfDatabase}) VALUES ({paramters})";
                    //create command on the current mysql connection
                    MySqlCommand _mysql_comm = new MySqlCommand(InsertQuery, _mysql_conn);
                    if (_mysql_comm.ExecuteNonQuery() != 0)    //insert data
                        Invoke(new Action(() => { progressBar_uploading.Value = 100; }));
                }//close connection
            }
            catch (Exception error)
            {
                //if any error occured,display error message.
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Save data to local txt
        /// </summary>
        private void SaveDataToTxt()
        {
            try
            {
                //create an instance of steamwriter to write the data into the file (default append the data)
                _streamWriter = new StreamWriter(FullFilePath, true);
                //use the full path to write the data into the file.
                _streamWriter.WriteLine(_dataIn);
                _streamWriter.Close();
            }
            catch (Exception ex)
            {
                //display error information
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Reset the operation button when disconnecting the port, having errors on saving data
        /// </summary>
        private void Reset_btn_receivepause()
        {
            //actions
            IsCaptureData = false;                     //flag set to false
            btn_receivepause.Text = "Start/Pause";     //reset text
            btn_receivepause.Enabled = false;          //disable the button
        }

        /// <summary>
        /// Update port related control 
        /// </summary>
        /// <param name="status">True indicates port disconnected, false indicates connected</param>
        private void PortRelatedContols(bool status)
        {
            comboBox_comport.Enabled = status;
            comboBox_baudrate.Enabled = status;
            comboBox_readmode.Enabled = status;
            txt_readmode_readto.Enabled = status;
            menu_comcontrol_connect.Enabled = status;
            menu_comcontrol_options.Enabled = status;
            progressBar_connection.Value = status ? 0 : 100;
        }

        #endregion

        #region UI control

        /// <summary>
        /// implement function to dray the window
        /// </summary>
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /// <summary>
        /// when the mouse over the panel and press, dray the window
        /// </summary>
        private void MenuStrip_menu_MouseDown(object sender, MouseEventArgs e)
        {
            //call the methods
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

    }

    /// <summary>
    /// Create a SerialPortPackage class to store the related information/object
    /// </summary>
    public class SerialPortPackage
    {
        #region fields

        public SerialPort _SerialPort;
        private bool _isSaveToTXT;
        public bool IsSaveToTXT { get { return _isSaveToTXT; } set { _isSaveToTXT = value; } }
        public string TxtPath = "N/A";
        public bool IsSaveToMySQL;

        #endregion

    }
}


