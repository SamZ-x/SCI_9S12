/*
 * Author: Xiaobin Zhu
 * Project: serial port data receiver for 9S12
 * history:
 *      May 31, 2022 creat project. 
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

//add references
using System.IO;
using System.IO.Ports;


namespace SCI_9S12
{
    public partial class Main : Form
    {
        #region Declaration and fields

        //port and data
        SerialPort _newSerialPort = null;
        String _dataIn = "";
        int _dataCounter = 0;

        //file IO
        StreamWriter _streamWriter = null;
        string FullFilePath;

        //MySQL

        #endregion


        public Main()
        {
            InitializeComponent();

            /*
             * pseudocode block
             * 
             * implement com port control function
             * 
             * 
            */



            #region Events

            Load += Main_Load;
            menu_comcontrol_connect.Click += Menu_comcontrol_connect_Click;
            menu_comcontrol_disconnect.Click += Menu_comcontrol_disconnect_Click;
            menu_file_savetotxt.Click += Menu_file_savetotxt_Click;
           

            #endregion

        }
        #region Event handlers

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

            //save data
            SaveReceivedData();

        }


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

        #endregion

        #region Helper methods
        /// <summary>
        /// control center of saving received data
        /// </summary>
        private void SaveReceivedData()
        {
            //base on the selection to save the data
            //option 1: local txt file
            if (menu_file_savetotxt.Checked)
                SaveDataToTxt();

            //option 2: Online MySQL database
            if (menu_file_savetomysql.Checked)
                WriteLine("mysql");
            
            //add more as need
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
