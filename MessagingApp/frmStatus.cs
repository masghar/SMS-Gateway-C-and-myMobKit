using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagingApp
{
    public partial class frmStatus : Form
    {
        public frmStatus()
        {
            InitializeComponent();
        }

        private void frmStatus_Load(object sender, EventArgs e)
        {

        }
        void get_response()
        {
        WebClient wp = new WebClient();
        string url = "http://192.168.100.19:1688/services/api/status/";
          var response=wp.DownloadString(url);
            get_data(response);
}
        void get_data(string response)
{
   // dataGridView1.Rows.clear();
    JArray fetch= JArray.Parse(response);
    if(fetch.Count()>0)
    {
        for(int i=0;dataGridView1.Rows.Count>i;i++)
        {
            int n=dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value=fetch[i]["Json ObjectName1"].ToString();
        }
    }
}
    }
}
