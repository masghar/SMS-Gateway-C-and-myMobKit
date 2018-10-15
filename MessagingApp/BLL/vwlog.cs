using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessagingApp.BLL
{
    public partial class vwLog
    {
        AutoSMSDataContext dc = DBHandler.getDataContext();

        List<vwLog> lst;
        public List<vwLog> LoadLogs()
        {
            try
            {
                var us = from d in dc.vwLogs

                        // where d.Mobile_Number != "+923008838181"
                         select new vwLog
                         {
                             Log_ID = d.Log_ID,
                             Name=d.Name,
                             Mobile_Number=d.Mobile_Number,
                             Command=d.Command,
                             Time=d.Time
                         };

                return lst = us.ToList();

            }catch(Exception e){
                throw e;
            }
        }
        public List<vwLog> SearchLog(string searchText)
        {
            try
            {
                var us = from d in dc.vwLogs

                         where  (d.Mobile_Number + d.Name + d.Command).Contains(searchText) 
                         select new vwLog
                         {
                             Log_ID = d.Log_ID,
                             Name = d.Name,
                             Mobile_Number = d.Mobile_Number,
                             Command = d.Command,
                             Time = d.Time
                         };

                return lst = us.ToList();

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        

    }
}
