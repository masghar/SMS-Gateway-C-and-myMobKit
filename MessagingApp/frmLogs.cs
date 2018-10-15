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
    public partial class frmLogs : Form
    {
        public frmLogs()
        {
            InitializeComponent();
        }

        private void frmLogs_Load(object sender, EventArgs e)
        {
            BLL.vwLog l = new BLL.vwLog();
            dgvwLogs.DataSource = l.LoadLogs();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BLL.vwLog l = new BLL.vwLog();
            dgvwLogs.DataSource= l.SearchLog(txtSearch.Text);
        }

        private void dgvwLogs_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

            ShowMessage m = new ShowMessage(dgvwLogs.SelectedRows[0].Cells[3].Value.ToString());
            m.ShowDialog();
        }
    }
}
