namespace MessagingApp
{
    partial class frmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.iTalk_Label4 = new iTalk.iTalk_Label();
            this.txtUsername = new iTalk.iTalk_TextBox_Small();
            this.txtMobileNumber = new iTalk.iTalk_TextBox_Small();
            this.cbIsActive = new iTalk.iTalk_CheckBox();
            this.btnAddUser = new iTalk.iTalk_Button_2();
            this.txtSection = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.SuspendLayout();
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(26, 32);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(58, 13);
            this.iTalk_Label1.TabIndex = 0;
            this.iTalk_Label1.Text = "Username";
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label3.Location = new System.Drawing.Point(26, 65);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(37, 13);
            this.iTalk_Label3.TabIndex = 0;
            this.iTalk_Label3.Text = "Active";
            // 
            // iTalk_Label4
            // 
            this.iTalk_Label4.AutoSize = true;
            this.iTalk_Label4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label4.Location = new System.Drawing.Point(26, 144);
            this.iTalk_Label4.Name = "iTalk_Label4";
            this.iTalk_Label4.Size = new System.Drawing.Size(87, 13);
            this.iTalk_Label4.TabIndex = 0;
            this.iTalk_Label4.Text = "Mobile Number";
            this.iTalk_Label4.Click += new System.EventHandler(this.iTalk_Label4_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Location = new System.Drawing.Point(126, 26);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = false;
            this.txtUsername.Size = new System.Drawing.Size(300, 28);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtMobileNumber.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMobileNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtMobileNumber.Location = new System.Drawing.Point(126, 138);
            this.txtMobileNumber.MaxLength = 32767;
            this.txtMobileNumber.Multiline = false;
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.ReadOnly = false;
            this.txtMobileNumber.Size = new System.Drawing.Size(300, 28);
            this.txtMobileNumber.TabIndex = 1;
            this.txtMobileNumber.Text = "+923";
            this.txtMobileNumber.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMobileNumber.UseSystemPasswordChar = false;
            // 
            // cbIsActive
            // 
            this.cbIsActive.BackColor = System.Drawing.Color.Transparent;
            this.cbIsActive.Checked = false;
            this.cbIsActive.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbIsActive.Location = new System.Drawing.Point(126, 63);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(120, 15);
            this.cbIsActive.TabIndex = 2;
            this.cbIsActive.Text = "Yes";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = null;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(260, 177);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(166, 40);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtSection
            // 
            this.txtSection.BackColor = System.Drawing.Color.Transparent;
            this.txtSection.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSection.ForeColor = System.Drawing.Color.DimGray;
            this.txtSection.Location = new System.Drawing.Point(126, 88);
            this.txtSection.MaxLength = 32767;
            this.txtSection.Multiline = false;
            this.txtSection.Name = "txtSection";
            this.txtSection.ReadOnly = false;
            this.txtSection.Size = new System.Drawing.Size(300, 28);
            this.txtSection.TabIndex = 5;
            this.txtSection.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSection.UseSystemPasswordChar = false;
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(26, 95);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(45, 13);
            this.iTalk_Label2.TabIndex = 4;
            this.iTalk_Label2.Text = "Section";
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 227);
            this.Controls.Add(this.txtSection);
            this.Controls.Add(this.iTalk_Label2);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.iTalk_Label4);
            this.Controls.Add(this.iTalk_Label3);
            this.Controls.Add(this.iTalk_Label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddUser";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_Label iTalk_Label3;
        private iTalk.iTalk_Label iTalk_Label4;
        private iTalk.iTalk_TextBox_Small txtUsername;
        private iTalk.iTalk_TextBox_Small txtMobileNumber;
        private iTalk.iTalk_CheckBox cbIsActive;
        private iTalk.iTalk_Button_2 btnAddUser;
        private iTalk.iTalk_TextBox_Small txtSection;
        private iTalk.iTalk_Label iTalk_Label2;
    }
}