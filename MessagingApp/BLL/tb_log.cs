using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingApp.BLL
{
    public partial class tb_log
    {
       
        
        AutoSMSDataContext dc = DBHandler.getDataContext();



        public bool closeConnection()
        {
            try
            {
                dc.Connection.Close();
                return true;
            }catch(Exception ex){
                return false;
            }
        
        }
        public List<tb_log> LoadlogsfromUsers()
        {
            
            var _user = from usr in dc.tb_logs
                        where usr.isCommandSent == false
                        select usr;
            return _user.ToList();
        }
        public List<tb_log> LoadlogsfromServer()
        {
            var _user = from usr in dc.tb_logs
                        where (usr.isCommandSent == true) && (usr.isUserReplied==false)
                        select usr;
            return _user.ToList();
        }

        public List<tb_log> LoadlogstoSendCommandToServer()
        {
            var _user = from usr in dc.tb_logs
                        where  usr.isFromServer==false && (usr.isCommandSent == false) && (usr.isUserReplied == false)
                        select usr;
            return _user.ToList();
        }
        public List<tb_log> LoadlogstoNotReplied()
        {
            var _user = from usr in dc.tb_logs
                        where usr.isFromServer == false && usr.isCommandSent == true && usr.isUserReplied == false
                        select usr;
            return _user.ToList();
        }
        public bool UpdateCommandSentToServer(tb_log log)
        {

            try
            {
                tb_log l = dc.tb_logs.Single(ls => ls.logger_id == log.logger_id);

                l.isCommandSent = log.isCommandSent;
                l.to_command_time_stamp = log.to_command_time_stamp;
              
                    
                dc.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
               
                throw ex;
            }
        }
        public void UpdateReplySentToUser(tb_log log)
        {

            try
            {
                tb_log l = dc.tb_logs.Single(ls => ls.logger_id == log.logger_id);

                l.isUserReplied = log.isUserReplied;
                l.to_user_time_stamp = log.to_user_time_stamp;

                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tb_log> LoadlogstoSendReplyToUser()
        {
            var _user = from usr in dc.tb_logs
                        where usr.isFromServer == true && usr.isUserReplied == false
                        select usr;
            return _user.ToList();
        }

        public bool SaveLog(tb_log log)
        {
            bool saved = false;
            try
            {
                dc.tb_logs.InsertOnSubmit(log);
                dc.SubmitChanges();
            }
            catch (Exception en)
            {
                throw en;
            }
            return saved;
        }
    }
}
