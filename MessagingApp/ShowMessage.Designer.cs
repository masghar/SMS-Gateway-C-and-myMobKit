namespace MessagingApp
{
    partial class ShowMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowMessage));
            this.rtMessage = new iTalk.iTalk_RichTextBox();
            this.SuspendLayout();
            // 
            // rtMessage
            // 
            this.rtMessage.AutoWordSelection = false;
            this.rtMessage.BackColor = System.Drawing.Color.Transparent;
            this.rtMessage.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rtMessage.ForeColor = System.Drawing.Color.DimGray;
            this.rtMessage.Location = new System.Drawing.Point(12, 12);
            this.rtMessage.Name = "rtMessage";
            this.rtMessage.ReadOnly = false;
            this.rtMessage.Size = new System.Drawing.Size(810, 302);
            this.rtMessage.TabIndex = 0;
            this.rtMessage.WordWrap = true;
            // 
            // ShowMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 326);
            this.Controls.Add(this.rtMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ShowMessage";
            this.Text = "Message";
            this.Load += new System.EventHandler(this.ShowMessage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_RichTextBox rtMessage;
    }
}