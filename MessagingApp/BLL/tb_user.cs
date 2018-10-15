using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessagingApp.BLL
{
    public partial class tb_user
    {
        AutoSMSDataContext dc = DBHandler.getDataContext();

       
        public List<tb_user> LoadUser()
        {
                var _user = from usr in dc.tb_users
                        where usr.isActive == true
                        select usr;
            return _user.ToList();
        }

        public List<tb_user> LoadActiveUserByMobileNumber(string number)
        {
            var _user = from usr in dc.tb_users
                        where usr.mobile_number==number &&  usr.isActive == true 
                        select usr;
            return _user.ToList();
        }
        public List<tb_user> LoadAllUsers()
        {
            var _user = from usr in dc.tb_users
                       
                        select usr;
            return _user.ToList();
        }
        public bool SaveUser(tb_user user)
        {
            bool saved = false;
            try
            {
                dc.tb_users.InsertOnSubmit(user);
                dc.SubmitChanges();
            }
            catch (Exception en)
            {
                throw en;
            }
            return saved;
        }
        public void DisableUser(int id)
        {

            try
            {
                tb_user u = dc.tb_users.Single(us => us.user_id == id);
                u.isActive = false;
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void ActivateUser(int id)
        {

            try
            {
                tb_user u = dc.tb_users.Single(us => us.user_id == id);
                u.isActive = true;
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
