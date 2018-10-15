using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.Threading.Tasks;

using MessagingApp.Model;

namespace MessagingApp
{
    /// <summary>
    /// HTTP gateway demo form.
    /// </summary>
    public partial class MessagingApp : Form
    {
        private const string NetworkInfoUrlPath = "services/api/status/network";

        private const string BatteryInfoUrlPath = "services/api/status/battery";

        private const string MessagesUrlPath = "services/api/messaging";

        private const string MessageStatusUrlPath = "services/api/messaging/status";


        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingApp"/> class.
        /// </summary>
        public MessagingApp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the frmHttp control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void frmHttp_Load(object sender, EventArgs e)
        {
            // Set focus
            this.ActiveControl = txtIPAddress;
        }

        private void btnRetrieveAllMessages_Click(object sender, EventArgs e)
        {
            RetrieveAllMessages();
        }


        private async void RetrieveAllMessages()
        {

            if (string.IsNullOrEmpty(txtIPAddress.Text))
            {
                MessageBox.Show("Please enter an IP address", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIPAddress.Focus();
                return;
            }


            try
            {

                btnRetrieveAllMessages.Enabled = false;

                /*
                HttpClientHandler handler = new HttpClientHandler();
                if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                {
                    handler.UseDefaultCredentials = true;
                    handler.Credentials = new NetworkCredential(txtUserName.Text, txtPassword.Text);
                }
                */

                using (var client = new HttpClient())
                {

                    string url = ConstructBaseUri();
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                    {
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                                    "Basic",
                                     Convert.ToBase64String(
                                     ASCIIEncoding.ASCII.GetBytes(
                                     string.Format("{0}:{1}", txtUserName.Text, txtPassword.Text))));
                    }


                    HttpResponseMessage response = await client.GetAsync(MessagesUrlPath);
                    if (response.IsSuccessStatusCode)
                    {
                        GetMessageResponse result = await response.Content.ReadAsAsync<GetMessageResponse>();
                        if (result.IsSuccessful)
                        {
                            txtOutput.Clear();
                            foreach (DeviceMessage msg in result.Messages)
                            {
                                AddToOutput(msg.ToString());
                                AddToOutput("");
                            }
                        }
                        else
                        {
                            MessageBox.Show(result.Description, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(response.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRetrieveAllMessages.Enabled = true;
            }
        }


        /// <summary>
        /// Builds the URL.
        /// </summary>
        /// <returns></returns>
        protected string ConstructBaseUri()
        {
            UriBuilder uriBuilder = new UriBuilder("http", txtIPAddress.Text, Convert.ToInt32(txtPort.Text));
            return uriBuilder.ToString();
        }

        private void AddToOutput(string text)
        {
            txtOutput.AppendText(text + "\r\n");
        }

        private void btnRetrieveNewMessages_Click(object sender, EventArgs e)
        {
            RetrieveNewMessages();
        }

        private async void RetrieveNewMessages()
        {
            if (string.IsNullOrEmpty(txtIPAddress.Text))
            {
                MessageBox.Show("Please enter an IP address", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIPAddress.Focus();
                return;
            }

            try
            {

                btnRetrieveNewMessages.Enabled = false;

                using (var client = new HttpClient())
                {

                    string url = ConstructBaseUri();
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                    {
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                                    "Basic",
                                     Convert.ToBase64String(
                                     ASCIIEncoding.ASCII.GetBytes(
                                     string.Format("{0}:{1}", txtUserName.Text, txtPassword.Text))));
                    }


                    HttpResponseMessage response = await client.GetAsync(MessagesUrlPath + "?status=0");
                    if (response.IsSuccessStatusCode)
                    {
                        GetMessageResponse result = await response.Content.ReadAsAsync<GetMessageResponse>();
                        if (result.IsSuccessful)
                        {
                            txtOutput.Clear();
                            foreach (DeviceMessage msg in result.Messages)
                            {
                                AddToOutput(msg.ToString());
                                AddToOutput("");
                            }
                        }
                        else
                        {
                            MessageBox.Show(result.Description, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(response.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRetrieveNewMessages.Enabled = true;
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private async void SendMessage()
        {

            if (string.IsNullOrEmpty(txtIPAddress.Text))
            {
                MessageBox.Show("Please enter an IP address", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIPAddress.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtContact.Text) || string.IsNullOrEmpty(txtMessage.Text))
            {
                MessageBox.Show("Please enter the contact name/number and the message", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContact.Focus();
                return;
            }

            try
            {

                btnSendMessage.Enabled = false;

                using (var client = new HttpClient())
                {

                    string url = ConstructBaseUri();
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                    {
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                                    "Basic",
                                     Convert.ToBase64String(
                                     ASCIIEncoding.ASCII.GetBytes(
                                     string.Format("{0}:{1}", txtUserName.Text, txtPassword.Text))));
                    }


                    var postData = new List<KeyValuePair<string, string>>();
                    postData.Add(new KeyValuePair<string, string>("to", txtContact.Text));
                    postData.Add(new KeyValuePair<string, string>("message", txtMessage.Text));
                    HttpContent content = new FormUrlEncodedContent(postData); 

                   
                    HttpResponseMessage response = await client.PostAsync(MessagesUrlPath, content);
                    if (response.IsSuccessStatusCode)
                    {
                        PostMessageResponse result = await response.Content.ReadAsAsync<PostMessageResponse>();
                        if (result.IsSuccessful)
                        {
                            txtOutput.Clear();
                            AddToOutput(result.ToString());
                            AddToOutput("");
                        }
                        else
                        {
                            MessageBox.Show(result.Description, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(response.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSendMessage.Enabled = true;
            }
        }
    }
}
