/*
 * Author: Xiaobin Zhu
 * Project: serial port data receiver for 9S12
 * history:
 *      May 31, 2022 creat project. (UI, serial port connection, MySQL connection, export to txt file.)
 *      Jun 01, 2022 finished upload to MySQL
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


namespace SCI_9S12
{
    public partial class Main : Form
    {
        #region Declaration and fields

        //port and data
        SerialPort _newSerialPort = null;
        string _dataIn = "";
        int _dataCounter = 0;

        //file IO
        StreamWriter _streamWriter = null;
        string FullFilePath;

        //MySQL
        MySqlConnection _mysql_conn = null;
        string connstr = "";
        DatabaseInfo _dbInfo;
        #endregion


        public Main()
        {
            InitializeComponent();

            //set app display in center screen
            StartPosition = FormStartPosition.CenterScreen;

            #region Events
            //main form events
            Load += Main_Load;

            //com port control events
            menu_comcontrol_connect.Click += Menu_comcontrol_connect_Click;
            menu_comcontrol_disconnect.Click += Menu_comcontrol_disconnect_Click;

            //file events
            menu_file_savetotxt.Click += Menu_file_savetotxt_Click;
            menu_file_savetomysql.Click += Menu_file_savetomysql_Click;
            menu_file_close.Click += (sender, e) => { Application.Exit(); };       //close APP
            menu_about.Click += (sender, e) => { new Help_Page().ShowDialog(); };  //show the help doc
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
        }

        /// <summary>
        /// Operation after receiving data
        /// </summary>
        private void _newSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Use to indicate receiving data.
            _dataCounter = _dataCounter == 100 ? 0 : ++_dataCounter;
            //indicate receiving data
            Invoke(new Action(() => { progressBar_receiving.Value = _dataCounter; }));

            //retrieve data from current port
            _dataIn = _newSerialPort.ReadExisting();

            /*
             *  data manipulation part  
             *  slice the data into meaningful data
             *  store into a new data type (class/struct)
             *  
             */


            //save data control(base on user selection)
            SaveReceivedData();

        }

        /// <summary>
        /// Selection to save data into local txt file
        /// </summary>
        private void Menu_file_savetotxt_Click(object sender, EventArgs e)
        {
            //cancel save to txt
            if (menu_file_savetotxt.Checked)
            {
                //reset UI and return
                menu_file_savetotxt.Checked = false;
                progressBar_savetotxt.Value = 0;
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
            }

        }

        /// <summary>
        /// Selection to save data to online MySQL database(collect database config information, and connection test)
        /// </summary>
        private void Menu_file_savetomysql_Click(object sender, EventArgs e)
        {
            //cancel upload to mysql database
            if (menu_file_savetomysql.Checked)
            {
                menu_file_savetomysql.Checked = false;
                progressBar_savetomysql.Value = 0;
                return;
            }

            //open MySQL connection form to input the information
            MySQL_Login _mysqlLoginPage = new MySQL_Login(Location);   //pass the main form location to relocate the dialog form
            _mysqlLoginPage.ShowDialog();

            //get the database connection parameters and create the connectionstring
            _dbInfo = _mysqlLoginPage._mysqlInfo;

            //check the request(Cancel/Connect)
            if (_dbInfo.Request == "Cancel")
                return;

            //if request is not "Cancel". Construct the connection string
            connstr = $"SERVER={_dbInfo.ServerName};PORT={_dbInfo.Port};DATABASE={_dbInfo.DatabaseName};UID={_dbInfo.UserName};PASSWORD={_dbInfo.Password}";

            //connection test
            try
            {
                using (_mysql_conn = new MySqlConnection(connstr))
                {
                    _mysql_conn.Open();

                    //if connection is good, update the UI
                    menu_file_savetomysql.Checked = true;
                    progressBar_savetomysql.Value = 100;

                    //pop up page to select target table, fields

                    List<string> TableList = new List<string>();
                    List<string> FieldList = new List<string>();

                    string GetTablesNamesQuery = $"SHOW TABLES";
                    using (MySqlCommand _mysql_comm = new MySqlCommand(GetTablesNamesQuery, _mysql_conn))
                    {
                        MySqlDataReader _mySqlDataReader = _mysql_comm.ExecuteReader();

                        while (_mySqlDataReader.Read())
                        {
                            WriteLine(_mySqlDataReader[$"Tables_in_{_dbInfo.DatabaseName}"]);
                            TableList.Add(_mySqlDataReader[$"Tables_in_{_dbInfo.DatabaseName}"].ToString());
                        }
                       
                    }

                }
            }
            catch (TimeoutException)
            {
                //display error messge
                MessageBox.Show("Error: Unable to connect to MySQL. Connect operation timeout!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                //display error messge
                MessageBox.Show("Error: Unable to connect to MySQL, invalid info!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Create serial port connection 
        /// </summary>
        private void Menu_comcontrol_connect_Click(object sender, EventArgs e)
        {

            //setting validation
            if (comboBox_comport.SelectedIndex == -1 || comboBox_baudrate.SelectedIndex == -1)
            {
                //pop up error message
                MessageBox.Show("Error: Invalid Serial port info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //retrieve setting
            string Port = comboBox_comport.Text;
            int BaudRate = int.Parse(comboBox_baudrate.Text);

            //build connection and open
            _newSerialPort = new SerialPort(Port, BaudRate);

            //handle exception
            try
            {
                //open the current port
                _newSerialPort.Open();

                //indicator light up if succeed
                progressBar_connection.Value = 100;

                //limit the setting
                comboBox_comport.Enabled = false;
                comboBox_baudrate.Enabled = false;
                menu_comcontrol_connect.Enabled = false;
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

                //release the port parameter selection
                comboBox_comport.Enabled = true;
                comboBox_baudrate.Enabled = true;

                //reset the save method to default
                menu_file_savetotxt.Checked = false;
                menu_file_savetomysql.Checked = false;

                //reset the indicators
                progressBar_connection.Value = 0;
                progressBar_receiving.Value = 0;
                progressBar_savetotxt.Value = 0;
                progressBar_savetomysql.Value = 0;
                progressBar_uploading.Value = 0;
            }
        }

        #endregion

        #region Helper methods

        /// <summary>
        /// Control of saving received data
        /// </summary>
        private void SaveReceivedData()
        {
            //base on the selection to save the data
            //option 1: local txt file
            if (menu_file_savetotxt.Checked)
                SaveDataToTxt();

            //option 2: Online MySQL database
            if (menu_file_savetomysql.Checked)
                SaveDataToMySQL();

            //add more as need
        }

        /// <summary>
        /// Save data to MySQL
        /// </summary>
        private void SaveDataToMySQL()
        {
            //indicator
            Invoke(new Action( ()=> { progressBar_uploading.Value = 0; })); 

            //the MySQL Configure info has been verified and tested in info-collection part.
            //Connection should be good.
            try
            {
                //create connection to mysql
                using (_mysql_conn = new MySqlConnection(connstr))
                {
                    //open connection
                    _mysql_conn.Open();

                    //database opertation part               ---NEED to update the insert(only works on specific database, table)
                    string InsertQuery = $"INSERT INTO `dataIn`(`date`, `dataDetail`) VALUES('{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}','{_dataIn}')"; 
                    //create command on the current mysql connection
                    MySqlCommand _mysql_comm = new MySqlCommand(InsertQuery, _mysql_conn);
                    if(_mysql_comm.ExecuteNonQuery() != 0)    //insert data
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

        #endregion
    }
}
