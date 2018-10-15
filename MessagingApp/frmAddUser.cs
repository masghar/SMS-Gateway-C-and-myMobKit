using MessagingApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagingApp
{
    public partial class frmAddUser : Form
    {

        private const string NetworkInfoUrlPath = "services/api/status/network";

        private const string BatteryInfoUrlPath = "services/api/status/battery";

        private const string MessagesUrlPath = "services/api/messaging";

        private const string MessageStatusUrlPath = "services/api/messaging/status";
        string ipaddress,username, password,port,welcomemsg;
        
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void iTalk_Label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try{
            BLL.tb_user u = new BLL.tb_user();
            u.name = txtUsername.Text.Trim();
            u.section = txtSection.Text;
            u.mobile_number = txtMobileNumber.Text;
            u.isActive = cbIsActive.Checked;
            
            u.SaveUser(u);
            SendMessagetoUser(welcomemsg,txtMobileNumber.Text);
            MessageBox.Show("User created..");
            }catch (Exception ex){

                MessageBox.Show(ex.Message);
            }
            }


        private void frmAddUser_Load(object sender, EventArgs e)
        {
            BLL.tb_gateway_config c = new BLL.tb_gateway_config();
            List<BLL.tb_gateway_config> l = c.LoadConfig();
            if (l.Count > 0)
            {
                ipaddress = l[0].ipaddress;
                port = l[0].port;
                username = l[0].password;
                welcomemsg = l[0].welcomemsg;
                password = l[0].password;
            }
        }
        protected string ConstructBaseUri()
        {
            UriBuilder uriBuilder = new UriBuilder("http", ipaddress, Convert.ToInt32(port));
            return uriBuilder.ToString();
        }
        private async void SendMessagetoUser(String message_text, string number)
        {


            try
            {


                using (var client = new HttpClient())
                {

                    string url = ConstructBaseUri();
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    
                    if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                    {
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                                    "Basic",
                                     Convert.ToBase64String(
                                     ASCIIEncoding.ASCII.GetBytes(
                                     string.Format("{0}:{1}", username, password))));
                    }
                    


                    var postData = new List<KeyValuePair<string, string>>();
                    postData.Add(new KeyValuePair<string, string>("to", number));
                    postData.Add(new KeyValuePair<string, string>("message", message_text));
                    HttpContent content = new FormUrlEncodedContent(postData);


                    HttpResponseMessage response = await client.PostAsync(MessagesUrlPath, content);

                   
                    if (response.IsSuccessStatusCode)
                    {
                        PostMessageResponse result = await response.Content.ReadAsAsync<PostMessageResponse>();
                        if (result.IsSuccessful)
                        {
                          //  MessageBox.Show("Sent");

                            // message_sent = true;
                           // txtLogs.Text += DateTime.Now + "-" + ("Message Sent to User ..." + "\r\n");
                        }
                        else
                        {
                          //  MessageBox.Show(result.ToString());
                        }
                    }
                    else
                    {
                        
                    }
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }
}
