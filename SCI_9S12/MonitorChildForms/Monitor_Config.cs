using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SCI_9S12.MonitorChildForms
{
    public partial class Monitor_Config : Form
    {
        #region Declaration
        
        Main MainForm;

        #endregion

        public Monitor_Config(Main mainform)
        {
            InitializeComponent();

            //Get the serial port object of Main
            MainForm = mainform;

            #region Events
            Load += Monitor_Config_Load;
            MainForm.UpdatePortconfigEventhandler += MainForm_UpdatePortconfigEventhandler;
            MainForm.UpdateOutputconfigEventhandler += MainForm_UpdateOutputconfigEventhandler;
            #endregion
        }

        #region Event handlers

        /// <summary>
        /// Initial the sections
        /// </summary>
        private void Monitor_Config_Load(object sender, EventArgs e)
        {
            UpdatePortConfig();
            UpdateOutputConfig();
        }

        /// <summary>
        /// Update the output config when change the selection of saving
        /// </summary>
        private void MainForm_UpdateOutputconfigEventhandler()
        {
            UpdateOutputConfig();
        }

        /// <summary>
        /// Update the port config when change the status of port
        /// </summary>
        private void MainForm_UpdatePortconfigEventhandler()
        {
            UpdatePortConfig();
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Update the value of port paramters
        /// </summary>
        private void UpdatePortConfig()
        {
            //port parameter values
            if (MainForm.CurrentSerialPortPackage._SerialPort != null && MainForm.CurrentSerialPortPackage._SerialPort.IsOpen)
            {
                lbl_portname_value.Text = MainForm.CurrentSerialPortPackage._SerialPort.PortName;
                lbl_baudrate_value.Text = MainForm.CurrentSerialPortPackage._SerialPort.BaudRate.ToString();
                lbl_databits_value.Text = MainForm.CurrentSerialPortPackage._SerialPort.DataBits.ToString();
                lbl_parity_value.Text = MainForm.CurrentSerialPortPackage._SerialPort.Parity.ToString();
                lbl_stopbits_value.Text = MainForm.CurrentSerialPortPackage._SerialPort.StopBits.ToString();
                lbl_portstatus_light.BackColor = Color.Green;
                lbl_portstatus_value.Text =  "Connected";
            }
            else 
            {
                lbl_portname_value.Text = "N/A";
                lbl_baudrate_value.Text = "N/A";
                lbl_databits_value.Text = "N/A";
                lbl_parity_value.Text = "N/A";
                lbl_stopbits_value.Text = "N/A";
                lbl_portstatus_value.Text = "Disconnected";
                lbl_portstatus_light.BackColor = Color.Gray;
            }
        }

        /// <summary>
        /// Update the value of output configure
        /// </summary>
        private void UpdateOutputConfig()
        {
            //update status
            bool OutputEnable = MainForm.CurrentSerialPortPackage.IsSaveToTXT || MainForm.CurrentSerialPortPackage.IsSaveToMySQL;
            lbl_outputstatus_value.Text = OutputEnable ? "On" : "OFF";
            lbl_outputstatus_light.BackColor = OutputEnable ? Color.Green : Color.Gray;

            //SaveToTXT status
            lbl_savetotxt_value.Text = MainForm.CurrentSerialPortPackage.IsSaveToTXT ? "Enable" : "Disable";
            lbl_path_value.Text = MainForm.CurrentSerialPortPackage.TxtPath;

            //SaveToMySQL status
            lbl_savetomysql_value.Text = MainForm.CurrentSerialPortPackage.IsSaveToMySQL ? "Enable" : "Disable";
        }

        #endregion
    }
}
