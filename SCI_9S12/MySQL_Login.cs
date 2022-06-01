using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//add additional references
using System.IO;

namespace SCI_9S12
{
    //new type to store database info
    public struct DatabaseInfo
    {
        public string Request;
        public string ServerName;
        public string UserName;
        public string Password;
        public string Port;
        public string DatabaseName;
    }

    public partial class MySQL_Login : Form
    {
        #region Fields

        //use to store the database connection information
        public DatabaseInfo _mysqlInfo = new DatabaseInfo();
        Point MainFormLocation;
        #endregion


        public MySQL_Login(Point mainformlocaiton)
        {
            InitializeComponent();

            //get main form location
            MainFormLocation =  mainformlocaiton;

            #region Events

            //reset location
            Shown += (sender, e) => Location = mainformlocaiton;

            //menu
            menu_exit.Click += Menu_exit_Click;
            menu_help.Click += Menu_help_Click;          

            //button events
            btn_submit.Click += Btn_submit_Click;
            btn_clear.Click += Btn_clear_Click;

            //file events
            menu_file_export.Click += Menu_file_export_Click;
            menu_file_import.Click += Menu_file_import_Click;

            #endregion
        }

        /// <summary>
        /// display the help doc window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_help_Click(object sender, EventArgs e)
        {
            //show the help doc
            Help_Page HelpPage = new Help_Page();
            HelpPage.ShowDialog();
               
        }

        #region Event handlers

        /// <summary>
        /// Exit without submission
        /// </summary>
        private void Menu_exit_Click(object sender, EventArgs e)
        {
            //update the property to notify "Cancel" connect to MySQL
            _mysqlInfo.Request = "Cancel";
            this.Close();

        }


        /// <summary>
        /// Open file dialog to import a configure file
        /// </summary>
        private void Menu_file_import_Click(object sender, EventArgs e)
        {
            //open the dialog to select config file
            OpenFileDialog _importconfig = new OpenFileDialog();
            //read the txt file and extract config info into the textbox
            if (_importconfig.ShowDialog() == DialogResult.OK)
            {
                //store all config string in collection
                List<string> ConfigInfo = new List<string>(File.ReadAllLines(_importconfig.FileName));
                try
                {
                    //assigne value to textbox
                    txt_servername.Text = ConfigInfo[0].Substring(ConfigInfo[0].IndexOf(":") + 1);
                    txt_username.Text = ConfigInfo[1].Substring(ConfigInfo[1].IndexOf(":") + 1);
                    txt_password.Text = ConfigInfo[2].Substring(ConfigInfo[2].IndexOf(":") + 1);
                    txt_port.Text = ConfigInfo[3].Substring(ConfigInfo[3].IndexOf(":") + 1);
                    txt_databasename.Text = ConfigInfo[4].Substring(ConfigInfo[4].IndexOf(":") + 1);
                }
                catch
                {
                    MessageBox.Show("Error: configuration data invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Open save dialog to save the configure
        /// </summary>
        private void Menu_file_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog _saveconfig = new SaveFileDialog();
            _saveconfig.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            //open a filedialog to select the save path
            if (_saveconfig.ShowDialog() == DialogResult.OK)
            {
                //get the full path
                string ExportfileFullPath = _saveconfig.FileName;

                try
                {
                    //Overwirte the txt file
                    StreamWriter ExportStreamWriter = new StreamWriter(ExportfileFullPath, false);
                    //write to the txt file
                    ExportStreamWriter.WriteLine($"Server:{txt_servername.Text}");
                    ExportStreamWriter.WriteLine($"Username:{txt_username.Text}");
                    ExportStreamWriter.WriteLine($"Password:{txt_password.Text}");
                    ExportStreamWriter.WriteLine($"Port:{txt_port.Text}");
                    ExportStreamWriter.WriteLine($"Database:{txt_databasename.Text}");
                    //close streamwriter
                    ExportStreamWriter.Close();

                    MessageBox.Show("Export done!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    //display error information
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Collect the user input
        /// </summary>
        private void Btn_submit_Click(object sender, EventArgs e)
        {
            //if input empty, show error message
            if (txt_servername.Text.Trim() == "" || txt_username.Text.Trim() == "" || txt_password.Text.Trim() == ""
                 || txt_port.Text.Trim() == "" || txt_databasename.Text.Trim() == "")
            {
                MessageBox.Show("Error: Invalid MySQL information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //otherwise, get the parameters and save into the database information property
            _mysqlInfo.Request = "Connect";
            _mysqlInfo.ServerName = txt_servername.Text;
            _mysqlInfo.UserName = txt_username.Text;
            _mysqlInfo.Password = txt_password.Text;
            _mysqlInfo.Port = txt_port.Text;
            _mysqlInfo.DatabaseName = txt_databasename.Text;

            //close the dialog
            this.Close();
        }

        /// <summary>
        /// Clear the text box
        /// </summary>
        private void Btn_clear_Click(object sender, EventArgs e)
        {
            //clear all textbox control
            foreach (var control in Controls)
            {
                if (control is TextBox txt)
                    txt.Clear();
            }
        }

        /// <summary>
        /// Closing the window to cancel to link MySQL database
        /// </summary>
        private void MySQL_Login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        #endregion
    }
}
