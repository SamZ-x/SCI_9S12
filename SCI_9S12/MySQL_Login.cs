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
using MySql.Data.MySqlClient;

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
        public string ConnectiongString;
        public string InsetQuery;
    }

    public partial class MySQL_Login : Form
    {
        #region Fields

        //use to store the database connection information
        public DatabaseInfo _mysqlInfo = new DatabaseInfo();
        Point MainFormLocation;

        //MySQL
        MySqlConnection _mysql_conn = null;
        string connstr = "";
        //store the database detail information


        #endregion


        public MySQL_Login(Point mainformlocaiton)
        {
            InitializeComponent();

            //get main form location
            MainFormLocation =  mainformlocaiton;

            #region Events

            //Form events
            Shown += (sender, e) => Location = mainformlocaiton;   //reset location
            Load += MySQL_Login_Load;

            //menu
            menu_exit.Click += Menu_exit_Click;
            menu_help.Click += Menu_help_Click;          

            //button events
            btn_submit.Click += Btn_submit_Click;
            btn_clear.Click += Btn_clear_Click;
            btn_generatequery.Click += Btn_generatequery_Click;

            //file events
            menu_file_export.Click += Menu_file_export_Click;
            menu_file_import.Click += Menu_file_import_Click;

            //select control events
            comboBox_tables.SelectedIndexChanged += ComboBox_tables_SelectedIndexChanged;
            #endregion
        }

        #region Event handlers

        /// <summary>
        /// Generate Insert Query base on the user selection
        /// </summary>
        private void Btn_generatequery_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Initial the UI
        /// </summary>
        private void MySQL_Login_Load(object sender, EventArgs e)
        {
            //initialize UI
            comboBox_tables.SelectedIndex = 0;
            btn_generatequery.Enabled = false;
            btn_finish.Enabled = false;
        }

        /// <summary>
        /// Show the database fields in check box list
        /// </summary>
        private void ComboBox_tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            //not valid database name
            if (comboBox_tables.SelectedIndex == 0)
            {
                //clear the check box list
                checkedListBox_selectfields.Items.Clear();
                return;
            }

            //otherwise, connect database to retrieve all the fields
            string TargetTableName = comboBox_tables.Text;

            //connection
            try
            {
                using (_mysql_conn = new MySqlConnection(connstr))
                {
                    //open connection for operation
                    _mysql_conn.Open();

                    //retrieve avariable tables and display
                    string GetTablesNamesQuery = $"SHOW COLUMNS FROM {TargetTableName}";
                    using (MySqlCommand _mysql_comm = new MySqlCommand(GetTablesNamesQuery, _mysql_conn))
                    {
                        MySqlDataReader _mySqlDataReader = _mysql_comm.ExecuteReader();
                        List<string> FieldList = new List<string>();

                        while (_mySqlDataReader.Read())
                        {
                            FieldList.Add(_mySqlDataReader["Field"].ToString());
                        }

                        //Show avariable tables in dropdown list
                        Invoke(new Action(() => ShowDatabaseDetialToControl(FieldList, checkedListBox_selectfields)));


                    }
                }
            }
            catch(Exception ex)
            {
                //display error messge
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// display the help doc window
        /// </summary>
        private void Menu_help_Click(object sender, EventArgs e)
        {
            //show the help doc
            Help_Page HelpPage = new Help_Page();
            HelpPage.ShowDialog();
               
        }

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
        /// Collect the user input, test database connection
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

            //reset database table and fields and query
            comboBox_tables.Items.Clear();
            comboBox_tables.Items.Add("Select target table");
            comboBox_tables.SelectedIndex = 0;
            checkedListBox_selectfields.Items.Clear();
            

            //otherwise, get the parameters and save into the database information property
            _mysqlInfo.Request = "Connect";
            _mysqlInfo.ServerName = txt_servername.Text;
            _mysqlInfo.UserName = txt_username.Text;
            _mysqlInfo.Password = txt_password.Text;
            _mysqlInfo.Port = txt_port.Text;
            _mysqlInfo.DatabaseName = txt_databasename.Text;

            //if request is not "Cancel". Construct the connection string
            connstr = $"SERVER={_mysqlInfo.ServerName};PORT={_mysqlInfo.Port};DATABASE={_mysqlInfo.DatabaseName};UID={_mysqlInfo.UserName};PASSWORD={_mysqlInfo.Password}";

            //connection test
            try
            {
                using (_mysql_conn = new MySqlConnection(connstr))
                {
                    //open connection for operation
                    _mysql_conn.Open();
                    
                    _mysqlInfo.ConnectiongString = connstr;  //save the connectiong string after connecting successfully
                    //update UI                        
                    btn_generatequery.Enabled = true;
                    btn_finish.Enabled = true;

                    //retrieve avariable tables and display
                    string GetTablesNamesQuery = $"SHOW TABLES";
                    using (MySqlCommand _mysql_comm = new MySqlCommand(GetTablesNamesQuery, _mysql_conn))
                    {
                        MySqlDataReader _mySqlDataReader = _mysql_comm.ExecuteReader();
                        List<string> TableList = new List<string>();
                        while (_mySqlDataReader.Read())
                        {
                            TableList.Add(_mySqlDataReader[$"Tables_in_{_mysqlInfo.DatabaseName}"].ToString());
                        }

                        //Show avariable tables in dropdown list
                        Invoke(new Action(() => ShowDatabaseDetialToControl(TableList, comboBox_tables))) ;
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

        #endregion

        #region Helper methods

        /// <summary>
        /// Show database detial information (names, fields, etc) to the control
        /// </summary>
        /// <param name="itemlist">Information list</param>
        /// <param name="control">target Control (Limite to :  combo box, checklist box)</param>
        private void ShowDatabaseDetialToControl(List<string> itemlist, Control control)
        {
            if (control is ComboBox combobox)
                combobox.Items.AddRange(itemlist.ToArray());
            
            if(control is CheckedListBox checkedListbox)
                checkedListbox.Items.AddRange(itemlist.ToArray());
        }

        #endregion
    }
}
