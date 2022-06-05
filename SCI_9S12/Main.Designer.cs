
namespace SCI_9S12
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbox_comportcontrol = new System.Windows.Forms.GroupBox();
            this.btn_refreshcom = new System.Windows.Forms.Button();
            this.comboBox_baudrate = new System.Windows.Forms.ComboBox();
            this.comboBox_comport = new System.Windows.Forms.ComboBox();
            this.lbl_cpc_baudrate = new System.Windows.Forms.Label();
            this.lbl_cpc_comport = new System.Windows.Forms.Label();
            this.menuStrip_menu = new System.Windows.Forms.MenuStrip();
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_savetotxt = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_savetomysql = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_file_close = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_comcontrol = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_comcontrol_options = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_comcontrol_options_parity = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_options_parity = new System.Windows.Forms.ToolStripComboBox();
            this.menu_comcontrol_options_databits = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_options_databits = new System.Windows.Forms.ToolStripComboBox();
            this.menu_comcontrol_options_stopbits = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox__options_stopbits = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_comcontrol_connect = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_comcontrol_disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_monitor = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_about = new System.Windows.Forms.ToolStripMenuItem();
            this.gbox_stauts = new System.Windows.Forms.GroupBox();
            this.lbl_status_savetomysql = new System.Windows.Forms.Label();
            this.progressBar_savetomysql = new System.Windows.Forms.ProgressBar();
            this.lbl_status_savetotxt = new System.Windows.Forms.Label();
            this.progressBar_savetotxt = new System.Windows.Forms.ProgressBar();
            this.lbl_status_connection = new System.Windows.Forms.Label();
            this.progressBar_connection = new System.Windows.Forms.ProgressBar();
            this.groupBox_datacontrol = new System.Windows.Forms.GroupBox();
            this.txt_dataexample = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fieldsname = new System.Windows.Forms.TextBox();
            this.txt_fieldsCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_dataseparator = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar_uploading = new System.Windows.Forms.ProgressBar();
            this.lbl_uploading = new System.Windows.Forms.Label();
            this.lbl_receiving = new System.Windows.Forms.Label();
            this.progressBar_saving = new System.Windows.Forms.ProgressBar();
            this.btn_receivepause = new System.Windows.Forms.Button();
            this.gbox_comportcontrol.SuspendLayout();
            this.menuStrip_menu.SuspendLayout();
            this.gbox_stauts.SuspendLayout();
            this.groupBox_datacontrol.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_comportcontrol
            // 
            this.gbox_comportcontrol.Controls.Add(this.btn_refreshcom);
            this.gbox_comportcontrol.Controls.Add(this.comboBox_baudrate);
            this.gbox_comportcontrol.Controls.Add(this.comboBox_comport);
            this.gbox_comportcontrol.Controls.Add(this.lbl_cpc_baudrate);
            this.gbox_comportcontrol.Controls.Add(this.lbl_cpc_comport);
            this.gbox_comportcontrol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_comportcontrol.Location = new System.Drawing.Point(11, 28);
            this.gbox_comportcontrol.Name = "gbox_comportcontrol";
            this.gbox_comportcontrol.Size = new System.Drawing.Size(233, 96);
            this.gbox_comportcontrol.TabIndex = 0;
            this.gbox_comportcontrol.TabStop = false;
            this.gbox_comportcontrol.Text = "COM PORT CONTROL";
            // 
            // btn_refreshcom
            // 
            this.btn_refreshcom.AutoSize = true;
            this.btn_refreshcom.BackColor = System.Drawing.Color.Transparent;
            this.btn_refreshcom.FlatAppearance.BorderSize = 0;
            this.btn_refreshcom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_refreshcom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_refreshcom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refreshcom.Image = global::SCI_9S12.Properties.Resources.refresh_16px;
            this.btn_refreshcom.Location = new System.Drawing.Point(207, 25);
            this.btn_refreshcom.Name = "btn_refreshcom";
            this.btn_refreshcom.Size = new System.Drawing.Size(22, 22);
            this.btn_refreshcom.TabIndex = 4;
            this.btn_refreshcom.UseVisualStyleBackColor = false;
            // 
            // comboBox_baudrate
            // 
            this.comboBox_baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudrate.FormattingEnabled = true;
            this.comboBox_baudrate.Location = new System.Drawing.Point(83, 56);
            this.comboBox_baudrate.Name = "comboBox_baudrate";
            this.comboBox_baudrate.Size = new System.Drawing.Size(121, 25);
            this.comboBox_baudrate.TabIndex = 3;
            // 
            // comboBox_comport
            // 
            this.comboBox_comport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_comport.FormattingEnabled = true;
            this.comboBox_comport.Location = new System.Drawing.Point(83, 24);
            this.comboBox_comport.Name = "comboBox_comport";
            this.comboBox_comport.Size = new System.Drawing.Size(121, 25);
            this.comboBox_comport.TabIndex = 2;
            // 
            // lbl_cpc_baudrate
            // 
            this.lbl_cpc_baudrate.AutoSize = true;
            this.lbl_cpc_baudrate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpc_baudrate.Location = new System.Drawing.Point(6, 56);
            this.lbl_cpc_baudrate.Name = "lbl_cpc_baudrate";
            this.lbl_cpc_baudrate.Size = new System.Drawing.Size(77, 17);
            this.lbl_cpc_baudrate.TabIndex = 1;
            this.lbl_cpc_baudrate.Text = "BAUD RATE:";
            // 
            // lbl_cpc_comport
            // 
            this.lbl_cpc_comport.AutoSize = true;
            this.lbl_cpc_comport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpc_comport.Location = new System.Drawing.Point(6, 28);
            this.lbl_cpc_comport.Name = "lbl_cpc_comport";
            this.lbl_cpc_comport.Size = new System.Drawing.Size(76, 17);
            this.lbl_cpc_comport.TabIndex = 0;
            this.lbl_cpc_comport.Text = "COM PORT:";
            // 
            // menuStrip_menu
            // 
            this.menuStrip_menu.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.menu_comcontrol,
            this.menu_monitor,
            this.menu_about});
            this.menuStrip_menu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_menu.Name = "menuStrip_menu";
            this.menuStrip_menu.Size = new System.Drawing.Size(443, 25);
            this.menuStrip_menu.TabIndex = 1;
            this.menuStrip_menu.Text = "menuStrip1";
            // 
            // menu_file
            // 
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file_savetotxt,
            this.menu_file_savetomysql,
            this.toolStripSeparator1,
            this.menu_file_close});
            this.menu_file.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_file.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(40, 21);
            this.menu_file.Text = "File";
            // 
            // menu_file_savetotxt
            // 
            this.menu_file_savetotxt.Name = "menu_file_savetotxt";
            this.menu_file_savetotxt.Size = new System.Drawing.Size(167, 22);
            this.menu_file_savetotxt.Text = "Save to TXT";
            // 
            // menu_file_savetomysql
            // 
            this.menu_file_savetomysql.Name = "menu_file_savetomysql";
            this.menu_file_savetomysql.Size = new System.Drawing.Size(167, 22);
            this.menu_file_savetomysql.Text = "Save to MySQL";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // menu_file_close
            // 
            this.menu_file_close.Name = "menu_file_close";
            this.menu_file_close.Size = new System.Drawing.Size(167, 22);
            this.menu_file_close.Text = "Close";
            // 
            // menu_comcontrol
            // 
            this.menu_comcontrol.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_comcontrol_options,
            this.toolStripSeparator2,
            this.menu_comcontrol_connect,
            this.menu_comcontrol_disconnect});
            this.menu_comcontrol.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_comcontrol.Name = "menu_comcontrol";
            this.menu_comcontrol.Size = new System.Drawing.Size(97, 21);
            this.menu_comcontrol.Text = "Com Control";
            // 
            // menu_comcontrol_options
            // 
            this.menu_comcontrol_options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_comcontrol_options_parity,
            this.menu_comcontrol_options_databits,
            this.menu_comcontrol_options_stopbits});
            this.menu_comcontrol_options.Name = "menu_comcontrol_options";
            this.menu_comcontrol_options.Size = new System.Drawing.Size(180, 22);
            this.menu_comcontrol_options.Text = "More Option";
            // 
            // menu_comcontrol_options_parity
            // 
            this.menu_comcontrol_options_parity.AutoToolTip = true;
            this.menu_comcontrol_options_parity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBox_options_parity});
            this.menu_comcontrol_options_parity.Name = "menu_comcontrol_options_parity";
            this.menu_comcontrol_options_parity.Size = new System.Drawing.Size(180, 22);
            this.menu_comcontrol_options_parity.Text = "Parity";
            this.menu_comcontrol_options_parity.ToolTipText = "Default Parity None";
            // 
            // comboBox_options_parity
            // 
            this.comboBox_options_parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_options_parity.DropDownWidth = 100;
            this.comboBox_options_parity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_options_parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBox_options_parity.Name = "comboBox_options_parity";
            this.comboBox_options_parity.Size = new System.Drawing.Size(121, 23);
            // 
            // menu_comcontrol_options_databits
            // 
            this.menu_comcontrol_options_databits.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBox_options_databits});
            this.menu_comcontrol_options_databits.Name = "menu_comcontrol_options_databits";
            this.menu_comcontrol_options_databits.Size = new System.Drawing.Size(180, 22);
            this.menu_comcontrol_options_databits.Text = "DataBits";
            // 
            // comboBox_options_databits
            // 
            this.comboBox_options_databits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_options_databits.DropDownWidth = 100;
            this.comboBox_options_databits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_options_databits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_options_databits.Name = "comboBox_options_databits";
            this.comboBox_options_databits.Size = new System.Drawing.Size(121, 23);
            // 
            // menu_comcontrol_options_stopbits
            // 
            this.menu_comcontrol_options_stopbits.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBox__options_stopbits});
            this.menu_comcontrol_options_stopbits.Name = "menu_comcontrol_options_stopbits";
            this.menu_comcontrol_options_stopbits.Size = new System.Drawing.Size(180, 22);
            this.menu_comcontrol_options_stopbits.Text = "StopBits";
            // 
            // comboBox__options_stopbits
            // 
            this.comboBox__options_stopbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox__options_stopbits.DropDownWidth = 100;
            this.comboBox__options_stopbits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox__options_stopbits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBox__options_stopbits.Name = "comboBox__options_stopbits";
            this.comboBox__options_stopbits.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // menu_comcontrol_connect
            // 
            this.menu_comcontrol_connect.Name = "menu_comcontrol_connect";
            this.menu_comcontrol_connect.Size = new System.Drawing.Size(180, 22);
            this.menu_comcontrol_connect.Text = "Connect";
            // 
            // menu_comcontrol_disconnect
            // 
            this.menu_comcontrol_disconnect.Name = "menu_comcontrol_disconnect";
            this.menu_comcontrol_disconnect.Size = new System.Drawing.Size(180, 22);
            this.menu_comcontrol_disconnect.Text = "Disconnect";
            // 
            // menu_monitor
            // 
            this.menu_monitor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_monitor.Name = "menu_monitor";
            this.menu_monitor.Size = new System.Drawing.Size(69, 21);
            this.menu_monitor.Text = "Monitor";
            // 
            // menu_about
            // 
            this.menu_about.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_about.Name = "menu_about";
            this.menu_about.Size = new System.Drawing.Size(58, 21);
            this.menu_about.Text = "About";
            // 
            // gbox_stauts
            // 
            this.gbox_stauts.Controls.Add(this.lbl_status_savetomysql);
            this.gbox_stauts.Controls.Add(this.progressBar_savetomysql);
            this.gbox_stauts.Controls.Add(this.lbl_status_savetotxt);
            this.gbox_stauts.Controls.Add(this.progressBar_savetotxt);
            this.gbox_stauts.Controls.Add(this.lbl_status_connection);
            this.gbox_stauts.Controls.Add(this.progressBar_connection);
            this.gbox_stauts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_stauts.Location = new System.Drawing.Point(249, 28);
            this.gbox_stauts.Name = "gbox_stauts";
            this.gbox_stauts.Size = new System.Drawing.Size(181, 96);
            this.gbox_stauts.TabIndex = 2;
            this.gbox_stauts.TabStop = false;
            this.gbox_stauts.Text = "Functions";
            // 
            // lbl_status_savetomysql
            // 
            this.lbl_status_savetomysql.AutoSize = true;
            this.lbl_status_savetomysql.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_savetomysql.Location = new System.Drawing.Point(6, 65);
            this.lbl_status_savetomysql.Name = "lbl_status_savetomysql";
            this.lbl_status_savetomysql.Size = new System.Drawing.Size(102, 19);
            this.lbl_status_savetomysql.TabIndex = 5;
            this.lbl_status_savetomysql.Text = "SaveToMySQL:";
            // 
            // progressBar_savetomysql
            // 
            this.progressBar_savetomysql.Location = new System.Drawing.Point(111, 65);
            this.progressBar_savetomysql.Name = "progressBar_savetomysql";
            this.progressBar_savetomysql.Size = new System.Drawing.Size(56, 19);
            this.progressBar_savetomysql.TabIndex = 4;
            // 
            // lbl_status_savetotxt
            // 
            this.lbl_status_savetotxt.AutoSize = true;
            this.lbl_status_savetotxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_savetotxt.Location = new System.Drawing.Point(6, 43);
            this.lbl_status_savetotxt.Name = "lbl_status_savetotxt";
            this.lbl_status_savetotxt.Size = new System.Drawing.Size(75, 19);
            this.lbl_status_savetotxt.TabIndex = 3;
            this.lbl_status_savetotxt.Text = "SaveToTxt:";
            // 
            // progressBar_savetotxt
            // 
            this.progressBar_savetotxt.Location = new System.Drawing.Point(111, 43);
            this.progressBar_savetotxt.Name = "progressBar_savetotxt";
            this.progressBar_savetotxt.Size = new System.Drawing.Size(56, 19);
            this.progressBar_savetotxt.TabIndex = 2;
            // 
            // lbl_status_connection
            // 
            this.lbl_status_connection.AutoSize = true;
            this.lbl_status_connection.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_connection.Location = new System.Drawing.Point(6, 21);
            this.lbl_status_connection.Name = "lbl_status_connection";
            this.lbl_status_connection.Size = new System.Drawing.Size(83, 19);
            this.lbl_status_connection.TabIndex = 1;
            this.lbl_status_connection.Text = "Connection:";
            // 
            // progressBar_connection
            // 
            this.progressBar_connection.Location = new System.Drawing.Point(111, 21);
            this.progressBar_connection.Name = "progressBar_connection";
            this.progressBar_connection.Size = new System.Drawing.Size(56, 19);
            this.progressBar_connection.TabIndex = 0;
            // 
            // groupBox_datacontrol
            // 
            this.groupBox_datacontrol.Controls.Add(this.txt_dataexample);
            this.groupBox_datacontrol.Controls.Add(this.label6);
            this.groupBox_datacontrol.Controls.Add(this.label5);
            this.groupBox_datacontrol.Controls.Add(this.txt_fieldsname);
            this.groupBox_datacontrol.Controls.Add(this.txt_fieldsCount);
            this.groupBox_datacontrol.Controls.Add(this.label4);
            this.groupBox_datacontrol.Controls.Add(this.label3);
            this.groupBox_datacontrol.Controls.Add(this.comboBox_dataseparator);
            this.groupBox_datacontrol.Controls.Add(this.label2);
            this.groupBox_datacontrol.Controls.Add(this.label1);
            this.groupBox_datacontrol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_datacontrol.Location = new System.Drawing.Point(10, 208);
            this.groupBox_datacontrol.Name = "groupBox_datacontrol";
            this.groupBox_datacontrol.Size = new System.Drawing.Size(419, 171);
            this.groupBox_datacontrol.TabIndex = 9;
            this.groupBox_datacontrol.TabStop = false;
            this.groupBox_datacontrol.Text = "Data Control For Database";
            // 
            // txt_dataexample
            // 
            this.txt_dataexample.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_dataexample.Location = new System.Drawing.Point(118, 138);
            this.txt_dataexample.Name = "txt_dataexample";
            this.txt_dataexample.ReadOnly = true;
            this.txt_dataexample.Size = new System.Drawing.Size(287, 25);
            this.txt_dataexample.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data Example:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(9, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "* Select separator to format the data";
            // 
            // txt_fieldsname
            // 
            this.txt_fieldsname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fieldsname.Location = new System.Drawing.Point(222, 49);
            this.txt_fieldsname.Multiline = true;
            this.txt_fieldsname.Name = "txt_fieldsname";
            this.txt_fieldsname.ReadOnly = true;
            this.txt_fieldsname.Size = new System.Drawing.Size(183, 85);
            this.txt_fieldsname.TabIndex = 12;
            // 
            // txt_fieldsCount
            // 
            this.txt_fieldsCount.Location = new System.Drawing.Point(329, 18);
            this.txt_fieldsCount.Name = "txt_fieldsCount";
            this.txt_fieldsCount.ReadOnly = true;
            this.txt_fieldsCount.Size = new System.Drawing.Size(35, 25);
            this.txt_fieldsCount.TabIndex = 11;
            this.txt_fieldsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Selected Fields:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(9, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 48);
            this.label3.TabIndex = 9;
            this.label3.Text = "* Data format should highly match the \r\n   setting in order to upload data\r\n   co" +
    "rrectly ";
            // 
            // comboBox_dataseparator
            // 
            this.comboBox_dataseparator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_dataseparator.FormattingEnabled = true;
            this.comboBox_dataseparator.Items.AddRange(new object[] {
            "Select one",
            ",",
            "/",
            "\\",
            "|",
            "_",
            ";"});
            this.comboBox_dataseparator.Location = new System.Drawing.Point(118, 109);
            this.comboBox_dataseparator.Name = "comboBox_dataseparator";
            this.comboBox_dataseparator.Size = new System.Drawing.Size(98, 25);
            this.comboBox_dataseparator.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data Separator:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "* Enable when connected to database";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar_uploading);
            this.groupBox1.Controls.Add(this.lbl_uploading);
            this.groupBox1.Controls.Add(this.lbl_receiving);
            this.groupBox1.Controls.Add(this.progressBar_saving);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 77);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Status";
            // 
            // progressBar_uploading
            // 
            this.progressBar_uploading.Location = new System.Drawing.Point(80, 44);
            this.progressBar_uploading.Name = "progressBar_uploading";
            this.progressBar_uploading.Size = new System.Drawing.Size(74, 15);
            this.progressBar_uploading.TabIndex = 12;
            // 
            // lbl_uploading
            // 
            this.lbl_uploading.AutoSize = true;
            this.lbl_uploading.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uploading.Location = new System.Drawing.Point(9, 43);
            this.lbl_uploading.Name = "lbl_uploading";
            this.lbl_uploading.Size = new System.Drawing.Size(72, 17);
            this.lbl_uploading.TabIndex = 11;
            this.lbl_uploading.Text = "Uploading:";
            // 
            // lbl_receiving
            // 
            this.lbl_receiving.AutoSize = true;
            this.lbl_receiving.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_receiving.Location = new System.Drawing.Point(9, 21);
            this.lbl_receiving.Name = "lbl_receiving";
            this.lbl_receiving.Size = new System.Drawing.Size(49, 17);
            this.lbl_receiving.TabIndex = 10;
            this.lbl_receiving.Text = "Saving:";
            // 
            // progressBar_saving
            // 
            this.progressBar_saving.Location = new System.Drawing.Point(80, 22);
            this.progressBar_saving.Name = "progressBar_saving";
            this.progressBar_saving.Size = new System.Drawing.Size(74, 15);
            this.progressBar_saving.TabIndex = 9;
            // 
            // btn_receivepause
            // 
            this.btn_receivepause.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_receivepause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_receivepause.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_receivepause.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_receivepause.Location = new System.Drawing.Point(176, 131);
            this.btn_receivepause.Name = "btn_receivepause";
            this.btn_receivepause.Size = new System.Drawing.Size(254, 71);
            this.btn_receivepause.TabIndex = 11;
            this.btn_receivepause.Text = "Start/Pause";
            this.btn_receivepause.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(443, 405);
            this.Controls.Add(this.btn_receivepause);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_datacontrol);
            this.Controls.Add(this.gbox_stauts);
            this.Controls.Add(this.gbox_comportcontrol);
            this.Controls.Add(this.menuStrip_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip_menu;
            this.Name = "Main";
            this.Text = "SCI_9S12_PC";
            this.gbox_comportcontrol.ResumeLayout(false);
            this.gbox_comportcontrol.PerformLayout();
            this.menuStrip_menu.ResumeLayout(false);
            this.menuStrip_menu.PerformLayout();
            this.gbox_stauts.ResumeLayout(false);
            this.gbox_stauts.PerformLayout();
            this.groupBox_datacontrol.ResumeLayout(false);
            this.groupBox_datacontrol.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_comportcontrol;
        private System.Windows.Forms.ComboBox comboBox_baudrate;
        private System.Windows.Forms.ComboBox comboBox_comport;
        private System.Windows.Forms.Label lbl_cpc_baudrate;
        private System.Windows.Forms.Label lbl_cpc_comport;
        private System.Windows.Forms.MenuStrip menuStrip_menu;
        private System.Windows.Forms.ToolStripMenuItem menu_file;
        private System.Windows.Forms.ToolStripMenuItem menu_file_savetotxt;
        private System.Windows.Forms.ToolStripMenuItem menu_file_savetomysql;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menu_file_close;
        private System.Windows.Forms.ToolStripMenuItem menu_comcontrol;
        private System.Windows.Forms.ToolStripMenuItem menu_comcontrol_connect;
        private System.Windows.Forms.ToolStripMenuItem menu_comcontrol_disconnect;
        private System.Windows.Forms.ToolStripMenuItem menu_about;
        private System.Windows.Forms.GroupBox gbox_stauts;
        private System.Windows.Forms.Label lbl_status_savetomysql;
        private System.Windows.Forms.ProgressBar progressBar_savetomysql;
        private System.Windows.Forms.Label lbl_status_savetotxt;
        private System.Windows.Forms.ProgressBar progressBar_savetotxt;
        private System.Windows.Forms.Label lbl_status_connection;
        private System.Windows.Forms.ProgressBar progressBar_connection;
        private System.Windows.Forms.GroupBox groupBox_datacontrol;
        private System.Windows.Forms.ComboBox comboBox_dataseparator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_fieldsCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar_uploading;
        private System.Windows.Forms.Label lbl_uploading;
        private System.Windows.Forms.Label lbl_receiving;
        private System.Windows.Forms.ProgressBar progressBar_saving;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fieldsname;
        private System.Windows.Forms.TextBox txt_dataexample;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_receivepause;
        private System.Windows.Forms.Button btn_refreshcom;
        private System.Windows.Forms.ToolStripMenuItem menu_comcontrol_options;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menu_comcontrol_options_databits;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripComboBox comboBox_options_databits;
        private System.Windows.Forms.ToolStripMenuItem menu_comcontrol_options_stopbits;
        private System.Windows.Forms.ToolStripMenuItem menu_comcontrol_options_parity;
        private System.Windows.Forms.ToolStripComboBox comboBox_options_parity;
        private System.Windows.Forms.ToolStripComboBox comboBox__options_stopbits;
        private System.Windows.Forms.ToolStripMenuItem menu_monitor;
    }
}

