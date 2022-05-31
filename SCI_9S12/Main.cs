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

//add references
using System.IO;
using System.IO.Ports;              


namespace SCI_9S12
{
    public partial class Main : Form
    {
        #region Declaration and fields

        SerialPort _newSerialPort = null;      



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


            #endregion
            #region Helper methods
            #endregion
        }
        #region Event handlers

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
                //close the current port and reset the serial port
                _newSerialPort.Close();
                _newSerialPort = null;
                progressBar_connection.Value = 0;
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
            }
            catch (Exception ex)
            {
                //pop up error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
