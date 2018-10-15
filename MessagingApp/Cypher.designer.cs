namespace MessagingApp
{
    partial class Cypher
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtencrypter = new System.Windows.Forms.TextBox();
            this.txtDecrypter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtReverse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text To Encrypt";
            // 
            // txtencrypter
            // 
            this.txtencrypter.Location = new System.Drawing.Point(118, 39);
            this.txtencrypter.Name = "txtencrypter";
            this.txtencrypter.Size = new System.Drawing.Size(353, 20);
            this.txtencrypter.TabIndex = 1;
            // 
            // txtDecrypter
            // 
            this.txtDecrypter.Location = new System.Drawing.Point(118, 79);
            this.txtDecrypter.Multiline = true;
            this.txtDecrypter.Name = "txtDecrypter";
            this.txtDecrypter.Size = new System.Drawing.Size(353, 155);
            this.txtDecrypter.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(355, 240);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(116, 23);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Run Encrypter";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(233, 240);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(116, 23);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Run Decrypter";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtReverse
            // 
            this.txtReverse.Location = new System.Drawing.Point(118, 269);
            this.txtReverse.Name = "txtReverse";
            this.txtReverse.Size = new System.Drawing.Size(353, 20);
            this.txtReverse.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Decrypted Result";
            // 
            // Cypher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 335);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReverse);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDecrypter);
            this.Controls.Add(this.txtencrypter);
            this.Controls.Add(this.label1);
            this.Name = "Cypher";
            this.Text = "Cypher";
            this.Load += new System.EventHandler(this.Cypher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtencrypter;
        private System.Windows.Forms.TextBox txtDecrypter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtReverse;
        private System.Windows.Forms.Label label3;
    }
}