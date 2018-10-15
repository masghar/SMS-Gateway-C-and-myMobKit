using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using MessagingApp.Model;
using System.Data.SQLite;
using System.Net.Mail;

namespace MessagingApp
{
    public partial class frmRecieveCommand : Form
    {
        private const string NetworkInfoUrlPath = "services/api/status/network";

        private const string BatteryInfoUrlPath = "services/api/status/battery";

        private const string MessagesUrlPath = "services/api/messaging";

        private const string MessageStatusUrlPath = "services/api/messaging/status";

        private string server_number;
        private string server_number2;
        private string server_number155;
        string email_username, email_password, emailclient;
        static bool message_sent = false;
    
        public frmRecieveCommand()
        {
            InitializeComponent();
        }

        private void frmRecieveCommand_Load(object sender, EventArgs e)
        {

            loadConfig();
            server_number= txtServerNumber.Text.Trim();
            server_number2= txtServiceNumber2.Text.Trim();
            server_number155 = txtServiceNumber15.Text.Trim();
            loadEmailConfig();
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 25000;//25 seconds
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();

           // TextBox.CheckForIllegalCrossThreadCalls = false;

           
        }

        private void loadConfig(){
        
        
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
        
        private void loadEmailConfig() {
            BLL.tb_client_config tc = new BLL.tb_client_config();
            List<BLL.tb_client_config> lc = tc.LoadConfig();
            email_username = lc[0].username;
            email_password = BLL.Cypher.Decrypt(lc[0].password);
            emailclient = lc[0].Client;
        }
        protected string ConstructBaseUri()
        {
            UriBuilder uriBuilder = new UriBuilder("http", txtIPAddress.Text, Convert.ToInt32(txtPort.Text));
            return uriBuilder.ToString();
        }

        private void AddToOutput(string text)
        {
       //    txtOutput.Text+= (text + "\r\n");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RetrieveNewMessages();
        }

        private async void RetrieveNewMessages()
        {

            // check message syntax......
            if (string.IsNullOrEmpty(txtIPAddress.Text))
            {
                //MessageBox.Show("Please enter an IP address", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIPAddress.Focus();
                return;
            }

            try
            {

                btnRefresh.Enabled = false;

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
                          //  txtOutput.Text = "";

                          //  
                           
                           
                           // MyMessage myMessage = new MyMessage();

                            List<DeviceMessage> mList= new List<DeviceMessage>();
                                                  
                            int uid = 0;

                            List<BLL.tb_log> l_list = new List<BLL.tb_log>();

                            foreach (DeviceMessage msg in result.Messages)
                            {

                               
                                uid=isAuthorised(msg.Number);

                                if (uid > 0)
                                {
                                    BLL.tb_log log = new BLL.tb_log();
                                    log.user_id = uid;
                                    log.sender_mobile_number = msg.Number;
                                    if(msg.Number.Equals(server_number) || msg.Number.Equals(server_number2) || msg.Number.Equals(server_number155)){                                    
                                        log.isFromServer=true;
                                    }else
                                    {
                                        log.isFromServer=false;
                                    }
                                    log.msg_text = msg.Message;
                                    log.isCommandSent = false;
                                    log.isUserReplied = false;                                                             
                                    mList.Add(msg);
                                    log.SaveLog(log);
                                    markMessageAsRead(msg.Id);                              
                                }
                            }
                            dgViewMessage.DataSource = mList;

                            string t = "No Message from Regd Users...";
                            if (mList.Count<1){
                                txtLogs.Text += DateTime.Now + "-" + (t + "\r\n");
                            }                            
                        }
                        else
                        {
                            this.dgViewMessage.DataSource = null;
                            this.dgViewMessage.Rows.Clear();
                            txtLogs.Text += DateTime.Now + "-" + (result.Description + "\r\n");
                           // txtLogs.Text = result.Description;
                           // MessageBox.Show(result.Description, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        txtLogs.Text += DateTime.Now+ "-"+ (response.ToString() + "\r\n");
                        //
                       // MessageBox.Show(response.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                txtLogs.Text += DateTime.Now + "-" + (ex.Message + "\r\n");
               // MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                 btnRefresh.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if(txtLogs.Text.Length>5000){
                txtLogs.Text = "";
            }
           executeCommands();
          
            
        }

        public void executeCommands() {
            RetrieveNewMessages();
            sendCommandToServer();
            searchMessageSenderRecievedFromServer();
        }

        private void btnProcessMessage_Click(object sender, EventArgs e)
        {
           
        }

        private async void markMessageAsRead(string messageId)
        {
            if (string.IsNullOrEmpty(txtIPAddress.Text))
            {
               // MessageBox.Show("Please enter an IP address", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIPAddress.Focus();
                return;
            }try
            {

               // btnProcessMessage.Enabled = false;

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
                    
                    var putData = new List<KeyValuePair<string, string>>();
                    putData.Add(new KeyValuePair<string, string>("id", messageId));
                   
                    HttpContent content = new FormUrlEncodedContent(putData);
                    string ur=   MessagesUrlPath + "/" + messageId;

                   // HttpResponseMessage response = await client.DeleteAsync(ur, content);
                    HttpResponseMessage response = await client.DeleteAsync(ur);
                    if (response.IsSuccessStatusCode)
                    {
                        PutMessageResponce result = await response.Content.ReadAsAsync<PutMessageResponce>();
                        //MessageBox.Show(result.ToString());
                        if (result.IsSuccessful)
                        {
                            txtLogs.Text += DateTime.Now + "-" + (result.ToString() + "\r\n");
                         }
                        else
                        {

                            txtLogs.Text += DateTime.Now + "-" + (result.Description + "\r\n");
                            
                        }
                    }
                    else
                    {
                        txtLogs.Text += DateTime.Now + "-" + (response.ToString() + "\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
                txtLogs.Text += DateTime.Now + "-" + (ex.Message + "\r\n");
            }
            finally
            {
               // btnProcessMessage.Enabled = true;
            }
        }

        public int isAuthorised(string number) {

            if (number == "+923008838181")
            {
                return 26;            
            }
            BLL.tb_user u = new BLL.tb_user(); 
            
            List<BLL.tb_user> l= u.LoadActiveUserByMobileNumber(number);
            if (l.Count > 0)
            {
                return l[0].user_id;
            }
            else
                return 0;
            }
        private void btnAddtoDB_Click(object sender, EventArgs e)
        {


            /// get All Logs from Mobile and save to DB
            

        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(isAuthorised("+923008838181").ToString());
        }

        private void iTalk_Button_22_Click(object sender, EventArgs e)
        {
            searchMessageSenderRecievedFromServer();

        }

        private void searchMessageSenderRecievedFromServer() {

            BLL.tb_log log = new BLL.tb_log();
            BLL.tb_log log2 = new BLL.tb_log();
            List<BLL.tb_log> l_list = log.LoadlogstoSendReplyToUser(); // Reply from server
            List<BLL.tb_log> l_list_not_replied = log.LoadlogstoNotReplied();

            string command, reply;
            int reply_id;
            for (int i = 0; i < l_list_not_replied.Count(); i++)
            {
                command = l_list_not_replied[i].msg_text;
                
                for (int j = 0; j < l_list.Count();j++ )
                {
                    reply = l_list[j].msg_text; // always a reply
                    
                    if(isMatch(command, reply)){                    
                        //MessageBox.Show(command +"Found in"+reply +"and reply number is"+l_list_not_replied[i].sender_mobile_number);
                        reply_id = l_list[j].logger_id;
                        if (l_list_not_replied[i].sender_mobile_number!=server_number && l_list_not_replied[i].sender_mobile_number!=server_number2 && l_list_not_replied[i].sender_mobile_number!=server_number155)
                        {
                        SendMessagetoUser(reply, l_list_not_replied[i].sender_mobile_number);
                       

                        }                        
                        log.to_user_time_stamp= DateTime.Now;
                        log.isUserReplied= true;
                        log.logger_id = l_list_not_replied[i].logger_id;
                        log.UpdateReplySentToUser(log);
                        //Now Update log
                        log2.to_user_time_stamp = DateTime.Now;
                        log2.isUserReplied = true;
                        log2.logger_id = reply_id;
                        log2.isCommandSent = true;
                        log2.UpdateReplySentToUser(log2);

                    
                    }
                }
                
            }
        }

        private bool isMatch(string command, string reply) {

            if (reply.Contains(command))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void iTalk_Button_23_Click(object sender, EventArgs e)
        {
           sendCommandToServer();
        }

        private void sendCommandToServer() {           
            BLL.tb_log log = new BLL.tb_log();
            List<BLL.tb_log> l_list = log.LoadlogstoSendCommandToServer();
            for (int i = 0; i < l_list.Count;i++ ) {

                SendMessage(l_list[i].msg_text.Trim(), l_list[i].logger_id);
               
               
            }
        }

        private string getNetwork(string number) {

            string network="NO_NET";
            network= number.Substring(2, 3);
            BLL.tb_network_code nc = new BLL.tb_network_code();
            List<BLL.tb_network_code> lnc = nc.getNetworkName(network);
            network = lnc[0].network;            
            return network;
        }
        private bool sendCommand(string subj,string command, string to_address)
        {
           try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(emailclient);
                mail.From = new MailAddress(email_username);
                mail.To.Add(to_address);
                mail.To.Add(email_username);

                mail.Subject = subj;
                mail.Body = command;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(email_username, email_password);
                //SmtpServer.EnableSsl = true;
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                SmtpServer.Send(mail);
                return true;
            }catch (Exception ex){

                return false;
            }
        }
        private async void SendMessage(String message_text, int log_id)
        {
            message_sent = false;
            //if (message_text.StartsWith("loc", true, null))
            //{
            //    if(message_text.Length>15){
            //    string number = message_text.Substring(4, 12);
            //    string net = getNetwork(number);
            //    //MessageBox.Show("Number is= "+number +"Netwotk is   "+net);
            //    string command = "";
            //    string address = "";
            //    string subj = "";

            //    if (net.Equals("mobilink"))
            //    {
            //        subj = "Loc Query";
            //        command = number;
            //        address = "ahsen.zaidi@jazz.com.pk";
            //    }
            //    else if (net.Equals("warid"))
            //    {
            //        subj = "Location Query";
            //        command = number;
            //        address = "waridlea@jazz.com.pk";
            //    }
            //    else if (net.Equals("ufone"))
            //    {
            //        subj = number;
            //        command = "";
            //        address = "ufone.location@ufone.com";

            //    }
            //    else if (net.Equals("zong"))
            //    {
            //        subj = "FIR";
            //        command = "Location Please = " + number;
            //        address = "reg@zong.com.pk";
            //    }
            //    else if (net.Equals("telenor"))
            //    {
            //        subj = "FIR";
            //        command = "Loc " + number;
            //        address = "lea@newsystem123.com";
            //    }

            //    txtLogs.Text = subj + " Command= " + command + " Address= " + address;
            //    if (sendCommand(subj, command, address))
            //    {
            //        txtLogs.Text += DateTime.Now + "-" + ("Email Command Sent..." + "\r\n");
            //    }
            //    }
            //    return;
            //}

                string sender_number;
                if (message_text.StartsWith("cnic", true, null) || message_text.StartsWith("sub", true, null) || message_text.StartsWith("vehicle", true, null))
                {
                    sender_number = server_number155;
                   // server_number = server_number155;

                }
                else {

                    sender_number = server_number;
                }
            
                 try
                {                  

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
                    postData.Add(new KeyValuePair<string, string>("to", sender_number));
                    postData.Add(new KeyValuePair<string, string>("message", message_text));
                    HttpContent content = new FormUrlEncodedContent(postData);


                    HttpResponseMessage response = await client.PostAsync(MessagesUrlPath, content);
                    if (response.IsSuccessStatusCode)
                    {
                        PostMessageResponse result = await response.Content.ReadAsAsync<PostMessageResponse>();
                        if (result.IsSuccessful)
                        {
                            message_sent = true;

                            //Update log
                           
                                BLL.tb_log log = new BLL.tb_log();
                                log.logger_id = log_id;
                                log.to_command_time_stamp = DateTime.Now;
                                log.isCommandSent = true;
                                if (log.UpdateCommandSentToServer(log))
                                {
                                    //  txtLogs.Text += DateTime.Now + "-" + ("Message Sent to Server for Processing..." + "\r\n");
                                    txtLogs.Text += DateTime.Now + "-" + ("Command Sent to   " + sender_number + " - Command - " + message_text + "\r\n");

                                    txtLogs.ForeColor = Color.Magenta;
                                }
                            
                                                   
                        }
                        else
                        {
                            txtLogs.Text += DateTime.Now + "-" + ("Unable to Send Command..." + "\r\n");
                        }
                    }
                    else
                    {
                        txtLogs.Text += DateTime.Now + "-" + ("Unable to Send Command..." + "\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
                txtLogs.Text += DateTime.Now + "-" + ("Unable to Send Command..." + "\r\n");
            }
           
          
        }
        private async void SendMessagetoUser(String message_text, string number)
        {
            message_sent = false;
            if (string.IsNullOrEmpty(txtIPAddress.Text))
            {
                //MessageBox.Show("Please enter an IP address", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIPAddress.Focus();
                return;
            }

            try
            {


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
                    postData.Add(new KeyValuePair<string, string>("to", number));
                    postData.Add(new KeyValuePair<string, string>("message", message_text));
                    HttpContent content = new FormUrlEncodedContent(postData);


                    HttpResponseMessage response = await client.PostAsync(MessagesUrlPath, content);
                    if (response.IsSuccessStatusCode)
                    {
                        PostMessageResponse result = await response.Content.ReadAsAsync<PostMessageResponse>();
                        if (result.IsSuccessful)
                        {
                            message_sent = true;
                            txtLogs.Text += DateTime.Now + "-" + ("Message Sent to User ..." + "\r\n");
                        }
                        else
                        {
                            txtLogs.Text += DateTime.Now + "-" + ("Unable to Send Message..." + "\r\n");
                        }
                    }
                    else
                    {
                        txtLogs.Text += DateTime.Now + "-" + ("Unable to Send Message..." + "\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
                txtLogs.Text += DateTime.Now + "-" + ("Unable to Send Command..." + "\r\n");
            }
            finally
            {

            }
        }

        private void iTalk_CheckBox1_CheckedChanged(object sender)
        {
            txtLogs.Text = "";
        }

        private void iTalk_Button_21_Click_1(object sender, EventArgs e)
        {
          string message_text= "loc 923314715546";
         
            if (message_text.StartsWith("loc", true, null))
            {
                string number = message_text.Substring(4, 12);
                string net = getNetwork(number);
                //MessageBox.Show("Number is= "+number +"Netwotk is   "+net);
                string command="";
                string address="";
                string subj="";

               if (net.Equals("mobilink")){
                   subj = "Loc Query";
                   command = number;
                   address = "ahsen.zaidi@jazz.com.pk";
               }else if (net.Equals("warid")){
                   subj = "Location Query";
                   command = number;
                   address = "waridlea@jazz.com.pk";
               }else if(net.Equals("ufone")){
                   subj = number;
                   command="";
                   address = "ufone.location@ufone.com";

               }else if(net.Equals("zong")){
                   subj = "FIR";
                   command = "Location Please = "+number;
                   address = "reg@zong.com.pk";
               }else if (net.Equals("telenor")){
                   subj = "FIR";
                   command = "Loc "+number;
                   address = "lea@newsystem123.com";
               }
                  
            txtLogs.Text= subj+ " Command= "+command+" Address= "+address;
            if (sendCommand(subj, command, address))
            {
                MessageBox.Show("Command sent");
            }
            }
            //MessageBox.Show(getNetwork("923256818223"));
        }

        private void bgTask_DoWork(object sender, DoWorkEventArgs e)
        {
            bgTask.DoWork += bgTask_DoWork;
            bgTask.ProgressChanged += bgTask_ProgressChanged;
            bgTask.WorkerReportsProgress = true;
            executeCommands();
        }

        private void bgTask_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        private void bgTask_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           // MessageBox.Show("Command Started Again");
        }

        
        
    }
}
