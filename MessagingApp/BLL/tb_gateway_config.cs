using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessagingApp.BLL
{
    public partial class tb_gateway_config
    {
        AutoSMSDataContext dc = DBHandler.getDataContext();


        public List<tb_gateway_config> LoadConfig()
        {
            var _user = from usr in dc.tb_gateway_configs
                      
                        select usr;
            return _user.ToList();
        }



        public bool SaveConfig(tb_gateway_config config)
        {
            bool saved = false;
            try
            {

                dc.tb_gateway_configs.InsertOnSubmit(config);
                dc.SubmitChanges();
            }
            catch (Exception en)
            {
                throw en;
            }
            return saved;
        }
        public void UpdateConfig(tb_gateway_config con )
        {

            try
            {
                tb_gateway_config u = dc.tb_gateway_configs.Single(us => us.tb_id == con.tb_id);
                u.ipaddress = con.ipaddress;
                u.port = con.port;
                u.username = con.username;
                u.password = con.password;
                u.t15 = con.t15;
                u.tsc1 = con.tsc1;
                u.tsc2 = con.tsc2;
                dc.SubmitChanges();
            }

 

            catch (Exception ex)
            {

                throw ex;
            }

        }
        
        //public List<tb_users> LoadUserInfo(string Uid, string pwd)
        //{
        //    // BLL.PMISDataContext DC = new BLL.PMISDataContext(DBHandler.GetAvailableConnectionForPMISDataContext());
        //    var users = from usr in dc.tb_users
        //                where (usr.user_name == Uid) && (usr.password == pwd)
        //                select usr;
        //    return users.ToList();
        //} 
        //public bool SaveUser(User usr,int mode, List<Role> roles)
        //{
        //    bool saved = false;
        //    try
        //    {
        //        dc.Users.InsertOnSubmit(usr);
        //        foreach (Role rl in roles)
        //        {
        //            UserRole urole = new UserRole();
        //            urole.UserID = usr.User_Id;
        //            urole.RoleID = rl.RoleId;
        //            dc.UserRoles.InsertOnSubmit(urole);
        //        }
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception en)
        //    {
        //        throw en;
        //    }
        //    return saved;
        //}
        //public List<User> GetAllUser()
        //{

        //    try
        //    {
        //        var us = from u in dc.Users

        //                 where u.Fingerprint != "" || u.Fingerprint != null
        //                 select u;

        //        return us.ToList();

        //    }
        //    catch (Exception exp)
        //    {

        //        throw exp;
        //    }
        //}
        //public int GetUsertMaxId()
        //{

        //    var id = (from p in dc.tb_users
        //              select p.User_Id).Max();

        //    return Convert.ToInt32(id);

        //}
        //public void UpdateLastLogin(int id)
        //{

        //    try
        //    {
        //        User u = dc.tb_users.Single(us => us.id == id);
        //        DateTime now = DateTime.Now;
        //        //u.LastLogin = now;
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }

        //}
        //public void ChangePassword(int id, String pwd)
        //{

        //    try
        //    {
        //        User u = dc.Users.Single(us => us.User_Id == id);
        //        u.Password = pwd;
        //        dc.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }

        //}

    }
}
