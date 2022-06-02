
namespace SCI_9S12
{
    partial class MySQL_Login
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
            this.menuStrip_menu = new System.Windows.Forms.MenuStrip();
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_import = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_export = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_notearea = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_insertarea = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_databasename = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_servername = new System.Windows.Forms.TextBox();
            this.lbl_database = new System.Windows.Forms.Label();
            this.lbl_port = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_server = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_generatequery = new System.Windows.Forms.Button();
            this.checkedListBox_selectfields = new System.Windows.Forms.CheckedListBox();
            this.comboBox_tables = new System.Windows.Forms.ComboBox();
            this.lbl_selectfields = new System.Windows.Forms.Label();
            this.lbl_tables = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_insertquery = new System.Windows.Forms.TextBox();
            this.btn_finish = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_confirmtosubmitquery = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip_menu.SuspendLayout();
            this.groupBox_notearea.SuspendLayout();
            this.groupBox_insertarea.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_menu
            // 
            this.menuStrip_menu.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip_menu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.menu_help,
            this.menu_exit});
            this.menuStrip_menu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_menu.Name = "menuStrip_menu";
            this.menuStrip_menu.Size = new System.Drawing.Size(827, 25);
            this.menuStrip_menu.TabIndex = 12;
            this.menuStrip_menu.Text = "menuStrip1";
            // 
            // menu_file
            // 
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file_import,
            this.menu_file_export});
            this.menu_file.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(40, 21);
            this.menu_file.Text = "File";
            // 
            // menu_file_import
            // 
            this.menu_file_import.Name = "menu_file_import";
            this.menu_file_import.Size = new System.Drawing.Size(215, 22);
            this.menu_file_import.Text = "Import Configure (TXT)";
            // 
            // menu_file_export
            // 
            this.menu_file_export.Name = "menu_file_export";
            this.menu_file_export.Size = new System.Drawing.Size(215, 22);
            this.menu_file_export.Text = "Export Configure (TXT)";
            // 
            // menu_help
            // 
            this.menu_help.Name = "menu_help";
            this.menu_help.Size = new System.Drawing.Size(48, 21);
            this.menu_help.Text = "Help";
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menu_exit.Size = new System.Drawing.Size(42, 21);
            this.menu_exit.Text = "Exit";
            // 
            // groupBox_notearea
            // 
            this.groupBox_notearea.Controls.Add(this.label7);
            this.groupBox_notearea.Controls.Add(this.label3);
            this.groupBox_notearea.Controls.Add(this.label2);
            this.groupBox_notearea.Controls.Add(this.label1);
            this.groupBox_notearea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_notearea.Location = new System.Drawing.Point(0, 28);
            this.groupBox_notearea.Name = "groupBox_notearea";
            this.groupBox_notearea.Size = new System.Drawing.Size(825, 70);
            this.groupBox_notearea.TabIndex = 14;
            this.groupBox_notearea.TabStop = false;
            this.groupBox_notearea.Text = "MySQL Setting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "* Submit login info to verify the connection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "* Export to TXT file (Overwirte selected file)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "* Import from TXT file (See help)";
            // 
            // groupBox_insertarea
            // 
            this.groupBox_insertarea.Controls.Add(this.btn_clear);
            this.groupBox_insertarea.Controls.Add(this.btn_submit);
            this.groupBox_insertarea.Controls.Add(this.txt_databasename);
            this.groupBox_insertarea.Controls.Add(this.txt_port);
            this.groupBox_insertarea.Controls.Add(this.txt_password);
            this.groupBox_insertarea.Controls.Add(this.txt_username);
            this.groupBox_insertarea.Controls.Add(this.txt_servername);
            this.groupBox_insertarea.Controls.Add(this.lbl_database);
            this.groupBox_insertarea.Controls.Add(this.lbl_port);
            this.groupBox_insertarea.Controls.Add(this.lbl_password);
            this.groupBox_insertarea.Controls.Add(this.lbl_username);
            this.groupBox_insertarea.Controls.Add(this.lbl_server);
            this.groupBox_insertarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_insertarea.Location = new System.Drawing.Point(0, 97);
            this.groupBox_insertarea.Name = "groupBox_insertarea";
            this.groupBox_insertarea.Size = new System.Drawing.Size(271, 247);
            this.groupBox_insertarea.TabIndex = 15;
            this.groupBox_insertarea.TabStop = false;
            this.groupBox_insertarea.Text = "Login";
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(149, 202);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 31);
            this.btn_clear.TabIndex = 23;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(55, 202);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 31);
            this.btn_submit.TabIndex = 22;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            // 
            // txt_databasename
            // 
            this.txt_databasename.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_databasename.Location = new System.Drawing.Point(93, 170);
            this.txt_databasename.Name = "txt_databasename";
            this.txt_databasename.Size = new System.Drawing.Size(152, 23);
            this.txt_databasename.TabIndex = 21;
            // 
            // txt_port
            // 
            this.txt_port.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_port.Location = new System.Drawing.Point(93, 134);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(152, 23);
            this.txt_port.TabIndex = 20;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(93, 98);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(152, 23);
            this.txt_password.TabIndex = 19;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(93, 62);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(152, 23);
            this.txt_username.TabIndex = 18;
            // 
            // txt_servername
            // 
            this.txt_servername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_servername.Location = new System.Drawing.Point(93, 26);
            this.txt_servername.Name = "txt_servername";
            this.txt_servername.Size = new System.Drawing.Size(152, 23);
            this.txt_servername.TabIndex = 17;
            // 
            // lbl_database
            // 
            this.lbl_database.AutoSize = true;
            this.lbl_database.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_database.Location = new System.Drawing.Point(12, 169);
            this.lbl_database.Name = "lbl_database";
            this.lbl_database.Size = new System.Drawing.Size(75, 19);
            this.lbl_database.TabIndex = 16;
            this.lbl_database.Text = "Database:";
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_port.Location = new System.Drawing.Point(12, 133);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(42, 19);
            this.lbl_port.TabIndex = 15;
            this.lbl_port.Text = "Port:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(12, 97);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(77, 19);
            this.lbl_password.TabIndex = 14;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(12, 61);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(80, 19);
            this.lbl_username.TabIndex = 13;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_server
            // 
            this.lbl_server.AutoSize = true;
            this.lbl_server.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_server.Location = new System.Drawing.Point(12, 25);
            this.lbl_server.Name = "lbl_server";
            this.lbl_server.Size = new System.Drawing.Size(57, 19);
            this.lbl_server.TabIndex = 12;
            this.lbl_server.Text = "Server:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_generatequery);
            this.groupBox1.Controls.Add(this.checkedListBox_selectfields);
            this.groupBox1.Controls.Add(this.comboBox_tables);
            this.groupBox1.Controls.Add(this.lbl_selectfields);
            this.groupBox1.Controls.Add(this.lbl_tables);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(277, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 247);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table and Fields";
            // 
            // btn_generatequery
            // 
            this.btn_generatequery.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generatequery.Location = new System.Drawing.Point(59, 202);
            this.btn_generatequery.Name = "btn_generatequery";
            this.btn_generatequery.Size = new System.Drawing.Size(154, 31);
            this.btn_generatequery.TabIndex = 27;
            this.btn_generatequery.Text = "Generate Query";
            this.btn_generatequery.UseVisualStyleBackColor = true;
            // 
            // checkedListBox_selectfields
            // 
            this.checkedListBox_selectfields.CheckOnClick = true;
            this.checkedListBox_selectfields.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_selectfields.FormattingEnabled = true;
            this.checkedListBox_selectfields.Location = new System.Drawing.Point(16, 83);
            this.checkedListBox_selectfields.Name = "checkedListBox_selectfields";
            this.checkedListBox_selectfields.Size = new System.Drawing.Size(229, 109);
            this.checkedListBox_selectfields.TabIndex = 26;
            // 
            // comboBox_tables
            // 
            this.comboBox_tables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tables.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tables.FormattingEnabled = true;
            this.comboBox_tables.Items.AddRange(new object[] {
            "Select target table"});
            this.comboBox_tables.Location = new System.Drawing.Point(84, 25);
            this.comboBox_tables.Name = "comboBox_tables";
            this.comboBox_tables.Size = new System.Drawing.Size(161, 25);
            this.comboBox_tables.TabIndex = 24;
            // 
            // lbl_selectfields
            // 
            this.lbl_selectfields.AutoSize = true;
            this.lbl_selectfields.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectfields.Location = new System.Drawing.Point(12, 61);
            this.lbl_selectfields.Name = "lbl_selectfields";
            this.lbl_selectfields.Size = new System.Drawing.Size(95, 19);
            this.lbl_selectfields.TabIndex = 13;
            this.lbl_selectfields.Text = "Select Fields:";
            // 
            // lbl_tables
            // 
            this.lbl_tables.AutoSize = true;
            this.lbl_tables.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tables.Location = new System.Drawing.Point(12, 25);
            this.lbl_tables.Name = "lbl_tables";
            this.lbl_tables.Size = new System.Drawing.Size(56, 19);
            this.lbl_tables.TabIndex = 12;
            this.lbl_tables.Text = "Tables:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_confirmtosubmitquery);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_insertquery);
            this.groupBox2.Controls.Add(this.btn_finish);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(554, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 247);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Query";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "* Insert query only.";
            // 
            // txt_insertquery
            // 
            this.txt_insertquery.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_insertquery.Location = new System.Drawing.Point(7, 85);
            this.txt_insertquery.Multiline = true;
            this.txt_insertquery.Name = "txt_insertquery";
            this.txt_insertquery.ReadOnly = true;
            this.txt_insertquery.Size = new System.Drawing.Size(258, 69);
            this.txt_insertquery.TabIndex = 28;
            // 
            // btn_finish
            // 
            this.btn_finish.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finish.Location = new System.Drawing.Point(59, 202);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(154, 31);
            this.btn_finish.TabIndex = 27;
            this.btn_finish.Text = "Finish";
            this.btn_finish.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Insert Query:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "* Press \"Finish\" to confirm the MySQL Setup";
            // 
            // checkBox_confirmtosubmitquery
            // 
            this.checkBox_confirmtosubmitquery.AutoSize = true;
            this.checkBox_confirmtosubmitquery.ForeColor = System.Drawing.Color.Crimson;
            this.checkBox_confirmtosubmitquery.Location = new System.Drawing.Point(6, 160);
            this.checkBox_confirmtosubmitquery.Name = "checkBox_confirmtosubmitquery";
            this.checkBox_confirmtosubmitquery.Size = new System.Drawing.Size(158, 17);
            this.checkBox_confirmtosubmitquery.TabIndex = 32;
            this.checkBox_confirmtosubmitquery.Text = "Confirm to submit query";
            this.checkBox_confirmtosubmitquery.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "* Confirm the query to finish ";
            // 
            // MySQL_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 348);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_insertarea);
            this.Controls.Add(this.groupBox_notearea);
            this.Controls.Add(this.menuStrip_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip_menu;
            this.Name = "MySQL_Login";
            this.Text = "MySQL_Login";
            this.menuStrip_menu.ResumeLayout(false);
            this.menuStrip_menu.PerformLayout();
            this.groupBox_notearea.ResumeLayout(false);
            this.groupBox_notearea.PerformLayout();
            this.groupBox_insertarea.ResumeLayout(false);
            this.groupBox_insertarea.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip_menu;
        private System.Windows.Forms.ToolStripMenuItem menu_file;
        private System.Windows.Forms.ToolStripMenuItem menu_file_import;
        private System.Windows.Forms.ToolStripMenuItem menu_file_export;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_help;
        private System.Windows.Forms.GroupBox groupBox_notearea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_insertarea;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_databasename;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_servername;
        private System.Windows.Forms.Label lbl_database;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_server;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_tables;
        private System.Windows.Forms.Label lbl_selectfields;
        private System.Windows.Forms.Label lbl_tables;
        private System.Windows.Forms.CheckedListBox checkedListBox_selectfields;
        private System.Windows.Forms.Button btn_generatequery;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_insertquery;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox_confirmtosubmitquery;
        private System.Windows.Forms.Label label4;
    }
}