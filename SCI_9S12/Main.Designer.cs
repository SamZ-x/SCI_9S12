
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
            this.comboBox_baudrate = new System.Windows.Forms.ComboBox();
            this.comboBox_comport = new System.Windows.Forms.ComboBox();
            this.lbl_cpc_baudrate = new System.Windows.Forms.Label();
            this.lbl_cpc_comport = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_savetotxt = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_savetomysql = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_file_close = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_comcontrol = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_comcontrol_connect = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_comcontrol_disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_about = new System.Windows.Forms.ToolStripMenuItem();
            this.gbox_stauts = new System.Windows.Forms.GroupBox();
            this.lbl_status_savetomysql = new System.Windows.Forms.Label();
            this.progressBar_savetomysql = new System.Windows.Forms.ProgressBar();
            this.lbl_status_savetotxt = new System.Windows.Forms.Label();
            this.progressBar_savetotxt = new System.Windows.Forms.ProgressBar();
            this.lbl_status_connection = new System.Windows.Forms.Label();
            this.progressBar_connection = new System.Windows.Forms.ProgressBar();
            this.progressBar_receiving = new System.Windows.Forms.ProgressBar();
            this.gbox_comportcontrol.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbox_stauts.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_comportcontrol
            // 
            this.gbox_comportcontrol.Controls.Add(this.comboBox_baudrate);
            this.gbox_comportcontrol.Controls.Add(this.comboBox_comport);
            this.gbox_comportcontrol.Controls.Add(this.lbl_cpc_baudrate);
            this.gbox_comportcontrol.Controls.Add(this.lbl_cpc_comport);
            this.gbox_comportcontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_comportcontrol.Location = new System.Drawing.Point(12, 42);
            this.gbox_comportcontrol.Name = "gbox_comportcontrol";
            this.gbox_comportcontrol.Size = new System.Drawing.Size(233, 102);
            this.gbox_comportcontrol.TabIndex = 0;
            this.gbox_comportcontrol.TabStop = false;
            this.gbox_comportcontrol.Text = "COM PORT CONTROL";
            // 
            // comboBox_baudrate
            // 
            this.comboBox_baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudrate.FormattingEnabled = true;
            this.comboBox_baudrate.Location = new System.Drawing.Point(96, 56);
            this.comboBox_baudrate.Name = "comboBox_baudrate";
            this.comboBox_baudrate.Size = new System.Drawing.Size(121, 24);
            this.comboBox_baudrate.TabIndex = 3;
            // 
            // comboBox_comport
            // 
            this.comboBox_comport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_comport.FormattingEnabled = true;
            this.comboBox_comport.Location = new System.Drawing.Point(96, 24);
            this.comboBox_comport.Name = "comboBox_comport";
            this.comboBox_comport.Size = new System.Drawing.Size(121, 24);
            this.comboBox_comport.TabIndex = 2;
            // 
            // lbl_cpc_baudrate
            // 
            this.lbl_cpc_baudrate.AutoSize = true;
            this.lbl_cpc_baudrate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpc_baudrate.Location = new System.Drawing.Point(7, 55);
            this.lbl_cpc_baudrate.Name = "lbl_cpc_baudrate";
            this.lbl_cpc_baudrate.Size = new System.Drawing.Size(84, 19);
            this.lbl_cpc_baudrate.TabIndex = 1;
            this.lbl_cpc_baudrate.Text = "BAUD RATE:";
            // 
            // lbl_cpc_comport
            // 
            this.lbl_cpc_comport.AutoSize = true;
            this.lbl_cpc_comport.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpc_comport.Location = new System.Drawing.Point(7, 23);
            this.lbl_cpc_comport.Name = "lbl_cpc_comport";
            this.lbl_cpc_comport.Size = new System.Drawing.Size(83, 19);
            this.lbl_cpc_comport.TabIndex = 0;
            this.lbl_cpc_comport.Text = "COM PORT:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.menu_comcontrol,
            this.menu_about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(446, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_file
            // 
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file_savetotxt,
            this.menu_file_savetomysql,
            this.toolStripSeparator1,
            this.menu_file_close});
            this.menu_file.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(40, 21);
            this.menu_file.Text = "File";
            // 
            // menu_file_savetotxt
            // 
            this.menu_file_savetotxt.Name = "menu_file_savetotxt";
            this.menu_file_savetotxt.Size = new System.Drawing.Size(180, 22);
            this.menu_file_savetotxt.Text = "Save to TXT";
            // 
            // menu_file_savetomysql
            // 
            this.menu_file_savetomysql.Name = "menu_file_savetomysql";
            this.menu_file_savetomysql.Size = new System.Drawing.Size(180, 22);
            this.menu_file_savetomysql.Text = "Save to MySQL";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menu_file_close
            // 
            this.menu_file_close.Name = "menu_file_close";
            this.menu_file_close.Size = new System.Drawing.Size(180, 22);
            this.menu_file_close.Text = "Close";
            // 
            // menu_comcontrol
            // 
            this.menu_comcontrol.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_comcontrol_connect,
            this.menu_comcontrol_disconnect});
            this.menu_comcontrol.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_comcontrol.Name = "menu_comcontrol";
            this.menu_comcontrol.Size = new System.Drawing.Size(97, 21);
            this.menu_comcontrol.Text = "Com Control";
            // 
            // menu_comcontrol_connect
            // 
            this.menu_comcontrol_connect.Name = "menu_comcontrol_connect";
            this.menu_comcontrol_connect.Size = new System.Drawing.Size(142, 22);
            this.menu_comcontrol_connect.Text = "Connect";
            // 
            // menu_comcontrol_disconnect
            // 
            this.menu_comcontrol_disconnect.Name = "menu_comcontrol_disconnect";
            this.menu_comcontrol_disconnect.Size = new System.Drawing.Size(142, 22);
            this.menu_comcontrol_disconnect.Text = "Disconnect";
            // 
            // menu_about
            // 
            this.menu_about.Name = "menu_about";
            this.menu_about.Size = new System.Drawing.Size(52, 21);
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
            this.gbox_stauts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_stauts.Location = new System.Drawing.Point(251, 42);
            this.gbox_stauts.Name = "gbox_stauts";
            this.gbox_stauts.Size = new System.Drawing.Size(181, 102);
            this.gbox_stauts.TabIndex = 2;
            this.gbox_stauts.TabStop = false;
            this.gbox_stauts.Text = "Status";
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
            // progressBar_receiving
            // 
            this.progressBar_receiving.Location = new System.Drawing.Point(13, 151);
            this.progressBar_receiving.Name = "progressBar_receiving";
            this.progressBar_receiving.Size = new System.Drawing.Size(419, 15);
            this.progressBar_receiving.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(446, 170);
            this.Controls.Add(this.progressBar_receiving);
            this.Controls.Add(this.gbox_stauts);
            this.Controls.Add(this.gbox_comportcontrol);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "SCI_9S12_PC";
            this.gbox_comportcontrol.ResumeLayout(false);
            this.gbox_comportcontrol.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbox_stauts.ResumeLayout(false);
            this.gbox_stauts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_comportcontrol;
        private System.Windows.Forms.ComboBox comboBox_baudrate;
        private System.Windows.Forms.ComboBox comboBox_comport;
        private System.Windows.Forms.Label lbl_cpc_baudrate;
        private System.Windows.Forms.Label lbl_cpc_comport;
        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private System.Windows.Forms.ProgressBar progressBar_receiving;
    }
}

