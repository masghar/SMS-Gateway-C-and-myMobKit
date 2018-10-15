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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStartService_Click(object sender, EventArgs e)
        {
            //Cehck All Configs are working
            frmRecieveCommand rc = new frmRecieveCommand();
            rc.Show();
        }

        private void btnStartLocService_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }

        private void btnUserPanel_Click(object sender, EventArgs e)
        {
            frmUserPanel p = new frmUserPanel();
            p.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmConfigurations c = new frmConfigurations();
            c.ShowDialog();
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            frmLogs logs = new frmLogs();
            logs.ShowDialog();
        }
    }
}
