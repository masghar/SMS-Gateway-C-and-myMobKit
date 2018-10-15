using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingApp.BLL
{
    public static class SQLConnection
    {

        public static SqlConnection getConnection() { 
         SqlConnection myConnection = new SqlConnection("user id=sa;" +
                                       "password=123;server=DESKTOP-E1J0I29/MSSQLSERVER328;" +
                                       "Trusted_Connection=yes;" +
                                       "database=AutoSMS; " +
                                       "connection timeout=60");
         return myConnection;

    }

        public static void closeConnection(SqlConnection con)
        {
            con.Close();
        }
    }
}
