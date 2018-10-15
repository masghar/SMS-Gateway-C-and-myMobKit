using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagingApp
{
    public partial class frmLogin : Form
    {
   
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


           

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
        public void connectToDatabase()
        {
          
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BLL.tb_login_user u = new BLL.tb_login_user();
            List<BLL.tb_login_user> l = u.getUser(txtUsername.Text, txtPassword.Text);
            if(l.Count>0){
                frmMain m = new frmMain();
                this.Hide();
                m.ShowDialog();
            
            }
        }
    }
}
