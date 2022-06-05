
namespace SCI_9S12
{
    partial class Monitor
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
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.btn_other = new System.Windows.Forms.Button();
            this.btn_config = new System.Windows.Forms.Button();
            this.btn_data = new System.Windows.Forms.Button();
            this.menuStrip_menu = new System.Windows.Forms.MenuStrip();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_sections = new System.Windows.Forms.Panel();
            this.panel_buttons.SuspendLayout();
            this.menuStrip_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_buttons
            // 
            this.panel_buttons.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_buttons.Controls.Add(this.btn_other);
            this.panel_buttons.Controls.Add(this.btn_config);
            this.panel_buttons.Controls.Add(this.btn_data);
            this.panel_buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_buttons.Location = new System.Drawing.Point(0, 25);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(800, 75);
            this.panel_buttons.TabIndex = 0;
            // 
            // btn_other
            // 
            this.btn_other.AutoSize = true;
            this.btn_other.BackColor = System.Drawing.Color.Transparent;
            this.btn_other.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_other.FlatAppearance.BorderSize = 0;
            this.btn_other.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_other.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_other.ForeColor = System.Drawing.Color.White;
            this.btn_other.Location = new System.Drawing.Point(235, 0);
            this.btn_other.Name = "btn_other";
            this.btn_other.Size = new System.Drawing.Size(114, 75);
            this.btn_other.TabIndex = 2;
            this.btn_other.Text = "Other";
            this.btn_other.UseVisualStyleBackColor = false;
            // 
            // btn_config
            // 
            this.btn_config.AutoSize = true;
            this.btn_config.BackColor = System.Drawing.Color.Transparent;
            this.btn_config.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_config.FlatAppearance.BorderSize = 0;
            this.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_config.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_config.ForeColor = System.Drawing.Color.White;
            this.btn_config.Location = new System.Drawing.Point(114, 0);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(121, 75);
            this.btn_config.TabIndex = 1;
            this.btn_config.Text = "Configure";
            this.btn_config.UseVisualStyleBackColor = false;
            // 
            // btn_data
            // 
            this.btn_data.AutoSize = true;
            this.btn_data.BackColor = System.Drawing.Color.Transparent;
            this.btn_data.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_data.FlatAppearance.BorderSize = 0;
            this.btn_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_data.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_data.ForeColor = System.Drawing.Color.White;
            this.btn_data.Location = new System.Drawing.Point(0, 0);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(114, 75);
            this.btn_data.TabIndex = 0;
            this.btn_data.Text = "Data";
            this.btn_data.UseVisualStyleBackColor = false;
            // 
            // menuStrip_menu
            // 
            this.menuStrip_menu.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_exit});
            this.menuStrip_menu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_menu.Name = "menuStrip_menu";
            this.menuStrip_menu.Size = new System.Drawing.Size(800, 25);
            this.menuStrip_menu.TabIndex = 1;
            this.menuStrip_menu.Text = "menuStrip1";
            // 
            // menu_exit
            // 
            this.menu_exit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(42, 21);
            this.menu_exit.Text = "Exit";
            // 
            // panel_sections
            // 
            this.panel_sections.BackColor = System.Drawing.Color.White;
            this.panel_sections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_sections.Location = new System.Drawing.Point(0, 100);
            this.panel_sections.Name = "panel_sections";
            this.panel_sections.Size = new System.Drawing.Size(800, 400);
            this.panel_sections.TabIndex = 2;
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel_sections);
            this.Controls.Add(this.panel_buttons);
            this.Controls.Add(this.menuStrip_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip_menu;
            this.Name = "Monitor";
            this.Text = "Monitor";
            this.panel_buttons.ResumeLayout(false);
            this.panel_buttons.PerformLayout();
            this.menuStrip_menu.ResumeLayout(false);
            this.menuStrip_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.MenuStrip menuStrip_menu;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.Panel panel_sections;
        private System.Windows.Forms.Button btn_other;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Button btn_data;
    }
}