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
             * initialize UI : show variable comport, baud rate
             * 
             * 
            */



            #region Events

            Load += Main_Load;


            #endregion
            #region Helper methods
            #endregion
        }
        #region Event handlers
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
