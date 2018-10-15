namespace MessagingApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogs = new iTalk.iTalk_Button_2();
            this.btnShutdown = new iTalk.iTalk_Button_2();
            this.btnSettings = new iTalk.iTalk_Button_2();
            this.btnUserPanel = new iTalk.iTalk_Button_2();
            this.btnStartService = new iTalk.iTalk_Button_2();
            this.btnStartLocService = new iTalk.iTalk_Button_2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 303);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(626, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MessagingApp.Properties.Resources.smartphone_SMS_icon__1_;
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 272);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.Color.Transparent;
            this.btnLogs.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnLogs.ForeColor = System.Drawing.Color.White;
            this.btnLogs.Image = global::MessagingApp.Properties.Resources.Mimetype_log_icon;
            this.btnLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogs.Location = new System.Drawing.Point(451, 129);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(163, 40);
            this.btnLogs.TabIndex = 0;
            this.btnLogs.Text = "Logs";
            this.btnLogs.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.BackColor = System.Drawing.Color.Transparent;
            this.btnShutdown.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnShutdown.ForeColor = System.Drawing.Color.White;
            this.btnShutdown.Image = global::MessagingApp.Properties.Resources.system_shutdown_icon;
            this.btnShutdown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdown.Location = new System.Drawing.Point(451, 189);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(163, 40);
            this.btnShutdown.TabIndex = 0;
            this.btnShutdown.Text = "Shutdown";
            this.btnShutdown.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::MessagingApp.Properties.Resources.settings_icon;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(282, 189);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(163, 40);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnUserPanel
            // 
            this.btnUserPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnUserPanel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnUserPanel.ForeColor = System.Drawing.Color.White;
            this.btnUserPanel.Image = global::MessagingApp.Properties.Resources.Office_Customer_Male_Light_icon__2_;
            this.btnUserPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserPanel.Location = new System.Drawing.Point(282, 129);
            this.btnUserPanel.Name = "btnUserPanel";
            this.btnUserPanel.Size = new System.Drawing.Size(163, 40);
            this.btnUserPanel.TabIndex = 0;
            this.btnUserPanel.Text = "User Panel";
            this.btnUserPanel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnUserPanel.Click += new System.EventHandler(this.btnUserPanel_Click);
            // 
            // btnStartService
            // 
            this.btnStartService.BackColor = System.Drawing.Color.Transparent;
            this.btnStartService.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnStartService.ForeColor = System.Drawing.Color.White;
            this.btnStartService.Image = global::MessagingApp.Properties.Resources.Start_icon__1_;
            this.btnStartService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartService.Location = new System.Drawing.Point(280, 25);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.Size = new System.Drawing.Size(334, 49);
            this.btnStartService.TabIndex = 0;
            this.btnStartService.Text = "Start Auto SMS Service";
            this.btnStartService.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnStartService.Click += new System.EventHandler(this.btnStartService_Click);
            // 
            // btnStartLocService
            // 
            this.btnStartLocService.BackColor = System.Drawing.Color.Transparent;
            this.btnStartLocService.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnStartLocService.ForeColor = System.Drawing.Color.White;
            this.btnStartLocService.Image = global::MessagingApp.Properties.Resources.location_icon;
            this.btnStartLocService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartLocService.Location = new System.Drawing.Point(280, 86);
            this.btnStartLocService.Name = "btnStartLocService";
            this.btnStartLocService.Size = new System.Drawing.Size(334, 49);
            this.btnStartLocService.TabIndex = 4;
            this.btnStartLocService.Text = "System Status";
            this.btnStartLocService.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnStartLocService.Visible = false;
            this.btnStartLocService.Click += new System.EventHandler(this.btnStartLocService_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MessagingApp.Properties.Resources.grunge_metal_plates_on_an_old_watercolour_background_1048_6388;
            this.ClientSize = new System.Drawing.Size(626, 325);
            this.Controls.Add(this.btnStartLocService);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogs);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnUserPanel);
            this.Controls.Add(this.btnStartService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Auto SMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Button_2 btnStartService;
        private System.Windows.Forms.PictureBox pictureBox1;
        private iTalk.iTalk_Button_2 btnUserPanel;
        private iTalk.iTalk_Button_2 btnLogs;
        private iTalk.iTalk_Button_2 btnSettings;
        private iTalk.iTalk_Button_2 btnShutdown;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private iTalk.iTalk_Button_2 btnStartLocService;
    }
}