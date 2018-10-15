using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
namespace MessagingApp
{
    public partial class Cypher : Form
    {

        //BLL.Cypher c = new BLL.Cypher();
        public Cypher()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
          

            txtDecrypter.Clear();
            txtDecrypter.Text = BLL.Cypher.Encrypt(txtencrypter.Text.Trim());
        }

        
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //txtDecrypter.Clear();
            txtReverse.Text = BLL.Cypher.Decrypt(txtDecrypter.Text.Trim());
        }

        private void Cypher_Load(object sender, EventArgs e)
        {

        }
    }
}

    
