using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagingApp
{
    public partial class frmConfigurations : Form
    {
        public frmConfigurations()
        {
            InitializeComponent();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = txtIPAddress.Text;
                BLL.tb_gateway_config c = new BLL.tb_gateway_config();
                List<BLL.tb_gateway_config> l = c.LoadConfig();
               
              //  c.tb_id = Convert.ToInt32(l[0]);
                c.tb_id = 1;
                c.ipaddress = ip;
                c.port = txtPort.Text;
                c.password = txtPassword.Text;
                c.username = txtUserName.Text;
                c.tsc1 = txtServerNumber.Text;
                c.tsc2 = txtServiceNumber2.Text;
                c.t15 = txtServiceNumber15.Text;
                c.UpdateConfig(c);
                MessageBox.Show("Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            {
            }
            
        }

        private void frmConfigurations_Load(object sender, EventArgs e)
        {
            BLL.tb_gateway_config c = new BLL.tb_gateway_config();
            List<BLL.tb_gateway_config> l = c.LoadConfig();
            if(l.Count>0){
                txtIPAddress.Text = l[0].ipaddress;
                txtPort.Text = l[0].port;
                txtPassword.Text = l[0].password;
                txtUserName.Text = l[0].username;
                txtServerNumber.Text = l[0].tsc1;
                txtServiceNumber2.Text = l[0].tsc2;
                txtServiceNumber15.Text = l[0].t15;


            }

        }
    }
}
