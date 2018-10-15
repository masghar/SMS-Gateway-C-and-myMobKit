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
    public partial class frmUserPanel : Form
    {
        public frmUserPanel()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Cypher c = new Cypher();
            c.ShowDialog();
        }

        private void frmUserPanel_Load(object sender, EventArgs e)
        {
            BLL.tb_user u = new BLL.tb_user();

            List<BLL.tb_user> l = u.LoadAllUsers();

            dgUserList.DataSource = l;

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser u = new frmAddUser();
            u.ShowDialog();
        }

        private void iTalk_LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            refresh();
        }
        private void refresh() {
            BLL.tb_user u = new BLL.tb_user();

            List<BLL.tb_user> l = u.LoadAllUsers();

            dgUserList.DataSource = l;
        }
        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
          int id = Convert.ToInt32(dgUserList.SelectedRows[0].Cells[0].Value);
          BLL.tb_user u= new BLL.tb_user();
          try{
            u.DisableUser(id);
            }catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Updated");
            refresh();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgUserList.SelectedRows[0].Cells[0].Value);
            BLL.tb_user u = new BLL.tb_user();
            try
            {
                u.ActivateUser(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Updated");
        }

    }
}    