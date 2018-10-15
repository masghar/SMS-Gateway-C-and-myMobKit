using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingApp.BLL
{
    class DBHandler
    {



        public static AutoSMSDataContext getDataContext()
        {

            //Server
            
            //return new PMISDataContext(ApplicationSecurity.DBHandler.GetAvailableConnectionForPMISDataContext());

            //Local
            //return new AutoSMSDataContext(getConnection());
            return new AutoSMSDataContext();

            //using (var db = new AutoSMSDataContext(getConnection()))
            //{
            //    return db;
            //}

        }
       
        public static SqlConnection getConnection()
        {
            Constants.SERVER_NAME = "127.0.0.1";
            SqlConnection con;
            try
            {
                string _server = "DESKTOP-E1J0I29\\MSSQLSERVER328";
                string uid = "sa";
                string pwd = "123";
                string db = "AutoSMS";
                con = new SqlConnection();
                con.ConnectionString = "data source =" + _server + ";user id=" + uid + "; password =" + pwd + "; Initial Catalog =" + db + ";Connection timeout=60;";
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
