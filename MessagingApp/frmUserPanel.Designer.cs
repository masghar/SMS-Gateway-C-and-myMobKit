namespace MessagingApp
{
    partial class frmUserPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserPanel));
            this.btnEncrypt = new iTalk.iTalk_Button_2();
            this.dgUserList = new System.Windows.Forms.DataGridView();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.btnAddUser = new iTalk.iTalk_Button_2();
            this.btnRemoveUser = new iTalk.iTalk_Button_2();
            this.iTalk_LinkLabel1 = new iTalk.iTalk_LinkLabel();
            this.btnActivate = new iTalk.iTalk_Button_2();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Image = null;
            this.btnEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncrypt.Location = new System.Drawing.Point(472, 282);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(101, 44);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Cypher";
            this.btnEncrypt.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // dgUserList
            // 
            this.dgUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUserList.Location = new System.Drawing.Point(12, 37);
            this.dgUserList.MultiSelect = false;
            this.dgUserList.Name = "dgUserList";
            this.dgUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUserList.Size = new System.Drawing.Size(561, 239);
            this.dgUserList.TabIndex = 1;
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(12, 9);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(83, 25);
            this.iTalk_Label1.TabIndex = 2;
            this.iTalk_Label1.Text = "User List";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = null;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(12, 282);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(106, 44);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveUser.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnRemoveUser.ForeColor = System.Drawing.Color.White;
            this.btnRemoveUser.Image = null;
            this.btnRemoveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveUser.Location = new System.Drawing.Point(135, 282);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(149, 44);
            this.btnRemoveUser.TabIndex = 3;
            this.btnRemoveUser.Text = "Deactivate User";
            this.btnRemoveUser.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // iTalk_LinkLabel1
            // 
            this.iTalk_LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(202)))));
            this.iTalk_LinkLabel1.AutoSize = true;
            this.iTalk_LinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_LinkLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.iTalk_LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
            this.iTalk_LinkLabel1.Location = new System.Drawing.Point(532, 18);
            this.iTalk_LinkLabel1.Name = "iTalk_LinkLabel1";
            this.iTalk_LinkLabel1.Size = new System.Drawing.Size(46, 13);
            this.iTalk_LinkLabel1.TabIndex = 4;
            this.iTalk_LinkLabel1.TabStop = true;
            this.iTalk_LinkLabel1.Text = "Refresh";
            this.iTalk_LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(202)))));
            this.iTalk_LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.iTalk_LinkLabel1_LinkClicked);
            // 
            // btnActivate
            // 
            this.btnActivate.BackColor = System.Drawing.Color.Transparent;
            this.btnActivate.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnActivate.ForeColor = System.Drawing.Color.White;
            this.btnActivate.Image = null;
            this.btnActivate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivate.Location = new System.Drawing.Point(301, 282);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(149, 44);
            this.btnActivate.TabIndex = 5;
            this.btnActivate.Text = "Activate";
            this.btnActivate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // frmUserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 341);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.iTalk_LinkLabel1);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.iTalk_Label1);
            this.Controls.Add(this.dgUserList);
            this.Controls.Add(this.btnEncrypt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserPanel";
            this.Text = "User Panel";
            this.Load += new System.EventHandler(this.frmUserPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Button_2 btnEncrypt;
        private System.Windows.Forms.DataGridView dgUserList;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_Button_2 btnAddUser;
        private iTalk.iTalk_Button_2 btnRemoveUser;
        private iTalk.iTalk_LinkLabel iTalk_LinkLabel1;
        private iTalk.iTalk_Button_2 btnActivate;
    }
}