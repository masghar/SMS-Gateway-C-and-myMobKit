namespace MessagingApp
{
    partial class frmLocationServices
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecieveCommand));
            this.dgViewMessage = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.iTalk_Button_21 = new iTalk.iTalk_Button_2();
            this.iTalk_Label8 = new iTalk.iTalk_Label();
            this.txtServiceNumber15 = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label7 = new iTalk.iTalk_Label();
            this.txtServiceNumber2 = new iTalk.iTalk_TextBox_Small();
            this.iTalk_CheckBox1 = new iTalk.iTalk_CheckBox();
            this.iTalk_Button_23 = new iTalk.iTalk_Button_2();
            this.iTalk_Button_22 = new iTalk.iTalk_Button_2();
            this.iTalk_Label6 = new iTalk.iTalk_Label();
            this.txtServerNumber = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label5 = new iTalk.iTalk_Label();
            this.txtLogs = new iTalk.iTalk_RichTextBox();
            this.iTalk_Label4 = new iTalk.iTalk_Label();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.txtPassword = new iTalk.iTalk_TextBox_Small();
            this.txtUserName = new iTalk.iTalk_TextBox_Small();
            this.btnRefresh = new iTalk.iTalk_Button_2();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.txtPort = new iTalk.iTalk_TextBox_Small();
            this.txtIPAddress = new iTalk.iTalk_TextBox_Small();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewMessage
            // 
            this.dgViewMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewMessage.Location = new System.Drawing.Point(21, 99);
            this.dgViewMessage.Name = "dgViewMessage";
            this.dgViewMessage.Size = new System.Drawing.Size(849, 113);
            this.dgViewMessage.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // iTalk_Button_21
            // 
            this.iTalk_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_21.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_21.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_21.Image = null;
            this.iTalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_21.Location = new System.Drawing.Point(624, 218);
            this.iTalk_Button_21.Name = "iTalk_Button_21";
            this.iTalk_Button_21.Size = new System.Drawing.Size(166, 40);
            this.iTalk_Button_21.TabIndex = 23;
            this.iTalk_Button_21.Text = "name";
            this.iTalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_21.Click += new System.EventHandler(this.iTalk_Button_21_Click_1);
            // 
            // iTalk_Label8
            // 
            this.iTalk_Label8.AutoSize = true;
            this.iTalk_Label8.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label8.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label8.Location = new System.Drawing.Point(754, 23);
            this.iTalk_Label8.Name = "iTalk_Label8";
            this.iTalk_Label8.Size = new System.Drawing.Size(101, 13);
            this.iTalk_Label8.TabIndex = 22;
            this.iTalk_Label8.Text = "Service Number 15";
            // 
            // txtServiceNumber15
            // 
            this.txtServiceNumber15.BackColor = System.Drawing.Color.Transparent;
            this.txtServiceNumber15.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtServiceNumber15.ForeColor = System.Drawing.Color.DimGray;
            this.txtServiceNumber15.Location = new System.Drawing.Point(743, 46);
            this.txtServiceNumber15.MaxLength = 32767;
            this.txtServiceNumber15.Multiline = false;
            this.txtServiceNumber15.Name = "txtServiceNumber15";
            this.txtServiceNumber15.ReadOnly = false;
            this.txtServiceNumber15.Size = new System.Drawing.Size(127, 28);
            this.txtServiceNumber15.TabIndex = 21;
            this.txtServiceNumber15.Text = "+923235962036";
            this.txtServiceNumber15.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtServiceNumber15.UseSystemPasswordChar = false;
            // 
            // iTalk_Label7
            // 
            this.iTalk_Label7.AutoSize = true;
            this.iTalk_Label7.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label7.Location = new System.Drawing.Point(503, 53);
            this.iTalk_Label7.Name = "iTalk_Label7";
            this.iTalk_Label7.Size = new System.Drawing.Size(95, 13);
            this.iTalk_Label7.TabIndex = 20;
            this.iTalk_Label7.Text = "Service Number 2";
            // 
            // txtServiceNumber2
            // 
            this.txtServiceNumber2.BackColor = System.Drawing.Color.Transparent;
            this.txtServiceNumber2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtServiceNumber2.ForeColor = System.Drawing.Color.DimGray;
            this.txtServiceNumber2.Location = new System.Drawing.Point(604, 46);
            this.txtServiceNumber2.MaxLength = 32767;
            this.txtServiceNumber2.Multiline = false;
            this.txtServiceNumber2.Name = "txtServiceNumber2";
            this.txtServiceNumber2.ReadOnly = false;
            this.txtServiceNumber2.Size = new System.Drawing.Size(127, 28);
            this.txtServiceNumber2.TabIndex = 19;
            this.txtServiceNumber2.Text = "+923245224453";
            this.txtServiceNumber2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtServiceNumber2.UseSystemPasswordChar = false;
            // 
            // iTalk_CheckBox1
            // 
            this.iTalk_CheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_CheckBox1.Checked = false;
            this.iTalk_CheckBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_CheckBox1.Location = new System.Drawing.Point(55, 271);
            this.iTalk_CheckBox1.Name = "iTalk_CheckBox1";
            this.iTalk_CheckBox1.Size = new System.Drawing.Size(120, 15);
            this.iTalk_CheckBox1.TabIndex = 18;
            this.iTalk_CheckBox1.Text = "Clear Logs";
            this.iTalk_CheckBox1.CheckedChanged += new iTalk.iTalk_CheckBox.CheckedChangedEventHandler(this.iTalk_CheckBox1_CheckedChanged);
            // 
            // iTalk_Button_23
            // 
            this.iTalk_Button_23.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_23.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_23.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_23.Image = null;
            this.iTalk_Button_23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_23.Location = new System.Drawing.Point(249, 218);
            this.iTalk_Button_23.Name = "iTalk_Button_23";
            this.iTalk_Button_23.Size = new System.Drawing.Size(166, 40);
            this.iTalk_Button_23.TabIndex = 17;
            this.iTalk_Button_23.Text = "Send Command";
            this.iTalk_Button_23.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_23.Click += new System.EventHandler(this.iTalk_Button_23_Click);
            // 
            // iTalk_Button_22
            // 
            this.iTalk_Button_22.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_22.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_22.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_22.Image = null;
            this.iTalk_Button_22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_22.Location = new System.Drawing.Point(452, 218);
            this.iTalk_Button_22.Name = "iTalk_Button_22";
            this.iTalk_Button_22.Size = new System.Drawing.Size(166, 40);
            this.iTalk_Button_22.TabIndex = 15;
            this.iTalk_Button_22.Text = "Send to User";
            this.iTalk_Button_22.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_22.Click += new System.EventHandler(this.iTalk_Button_22_Click);
            // 
            // iTalk_Label6
            // 
            this.iTalk_Label6.AutoSize = true;
            this.iTalk_Label6.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label6.Location = new System.Drawing.Point(503, 20);
            this.iTalk_Label6.Name = "iTalk_Label6";
            this.iTalk_Label6.Size = new System.Drawing.Size(95, 13);
            this.iTalk_Label6.TabIndex = 13;
            this.iTalk_Label6.Text = "Service Number 1";
            // 
            // txtServerNumber
            // 
            this.txtServerNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtServerNumber.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtServerNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtServerNumber.Location = new System.Drawing.Point(604, 12);
            this.txtServerNumber.MaxLength = 32767;
            this.txtServerNumber.Multiline = false;
            this.txtServerNumber.Name = "txtServerNumber";
            this.txtServerNumber.ReadOnly = false;
            this.txtServerNumber.Size = new System.Drawing.Size(127, 28);
            this.txtServerNumber.TabIndex = 12;
            this.txtServerNumber.Text = "+923225024559";
            this.txtServerNumber.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtServerNumber.UseSystemPasswordChar = false;
            // 
            // iTalk_Label5
            // 
            this.iTalk_Label5.AutoSize = true;
            this.iTalk_Label5.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label5.Location = new System.Drawing.Point(18, 271);
            this.iTalk_Label5.Name = "iTalk_Label5";
            this.iTalk_Label5.Size = new System.Drawing.Size(31, 13);
            this.iTalk_Label5.TabIndex = 10;
            this.iTalk_Label5.Text = "Logs";
            // 
            // txtLogs
            // 
            this.txtLogs.AutoWordSelection = false;
            this.txtLogs.BackColor = System.Drawing.Color.Transparent;
            this.txtLogs.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtLogs.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtLogs.Location = new System.Drawing.Point(21, 292);
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.Size = new System.Drawing.Size(677, 238);
            this.txtLogs.TabIndex = 9;
            this.txtLogs.WordWrap = true;
            // 
            // iTalk_Label4
            // 
            this.iTalk_Label4.AutoSize = true;
            this.iTalk_Label4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label4.Location = new System.Drawing.Point(273, 58);
            this.iTalk_Label4.Name = "iTalk_Label4";
            this.iTalk_Label4.Size = new System.Drawing.Size(56, 13);
            this.iTalk_Label4.TabIndex = 8;
            this.iTalk_Label4.Text = "Password";
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label3.Location = new System.Drawing.Point(26, 58);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(62, 13);
            this.iTalk_Label3.TabIndex = 7;
            this.iTalk_Label3.Text = "User Name";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(337, 53);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.Size = new System.Drawing.Size(160, 28);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "admin";
            this.txtPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUserName.ForeColor = System.Drawing.Color.DimGray;
            this.txtUserName.Location = new System.Drawing.Point(92, 53);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Multiline = false;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = false;
            this.txtUserName.Size = new System.Drawing.Size(171, 28);
            this.txtUserName.TabIndex = 6;
            this.txtUserName.Text = "admin";
            this.txtUserName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserName.UseSystemPasswordChar = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = null;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(21, 218);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(166, 40);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(273, 20);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(28, 13);
            this.iTalk_Label2.TabIndex = 3;
            this.iTalk_Label2.Text = "Port";
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(26, 20);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(60, 13);
            this.iTalk_Label1.TabIndex = 3;
            this.iTalk_Label1.Text = "IP Address";
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.Transparent;
            this.txtPort.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPort.ForeColor = System.Drawing.Color.DimGray;
            this.txtPort.Location = new System.Drawing.Point(337, 12);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Multiline = false;
            this.txtPort.Name = "txtPort";
            this.txtPort.ReadOnly = false;
            this.txtPort.Size = new System.Drawing.Size(160, 28);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "1688";
            this.txtPort.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPort.UseSystemPasswordChar = false;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtIPAddress.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtIPAddress.ForeColor = System.Drawing.Color.DimGray;
            this.txtIPAddress.Location = new System.Drawing.Point(92, 12);
            this.txtIPAddress.MaxLength = 32767;
            this.txtIPAddress.Multiline = false;
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.ReadOnly = false;
            this.txtIPAddress.Size = new System.Drawing.Size(171, 28);
            this.txtIPAddress.TabIndex = 1;
            this.txtIPAddress.Text = "192.168.8.96";
            this.txtIPAddress.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIPAddress.UseSystemPasswordChar = false;
            // 
            // frmRecieveCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 564);
            this.Controls.Add(this.iTalk_Button_21);
            this.Controls.Add(this.iTalk_Label8);
            this.Controls.Add(this.txtServiceNumber15);
            this.Controls.Add(this.iTalk_Label7);
            this.Controls.Add(this.txtServiceNumber2);
            this.Controls.Add(this.iTalk_CheckBox1);
            this.Controls.Add(this.iTalk_Button_23);
            this.Controls.Add(this.iTalk_Button_22);
            this.Controls.Add(this.iTalk_Label6);
            this.Controls.Add(this.txtServerNumber);
            this.Controls.Add(this.iTalk_Label5);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.iTalk_Label4);
            this.Controls.Add(this.iTalk_Label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.iTalk_Label2);
            this.Controls.Add(this.iTalk_Label1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.dgViewMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRecieveCommand";
            this.Text = "Message Gateway 1.0.0.18";
            this.Load += new System.EventHandler(this.frmLocationServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewMessage;
        private iTalk.iTalk_TextBox_Small txtIPAddress;
        private iTalk.iTalk_TextBox_Small txtPort;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_Button_2 btnRefresh;
        private iTalk.iTalk_TextBox_Small txtUserName;
        private iTalk.iTalk_TextBox_Small txtPassword;
        private iTalk.iTalk_Label iTalk_Label3;
        private iTalk.iTalk_Label iTalk_Label4;
        private iTalk.iTalk_RichTextBox txtLogs;
        private iTalk.iTalk_Label iTalk_Label5;
        private System.Windows.Forms.Timer timer1;
        private iTalk.iTalk_TextBox_Small txtServerNumber;
        private iTalk.iTalk_Label iTalk_Label6;
        private iTalk.iTalk_Button_2 iTalk_Button_22;
        private iTalk.iTalk_Button_2 iTalk_Button_23;
        private iTalk.iTalk_CheckBox iTalk_CheckBox1;
        private iTalk.iTalk_TextBox_Small txtServiceNumber2;
        private iTalk.iTalk_Label iTalk_Label7;
        private iTalk.iTalk_TextBox_Small txtServiceNumber15;
        private iTalk.iTalk_Label iTalk_Label8;
        private iTalk.iTalk_Button_2 iTalk_Button_21;
    }
}