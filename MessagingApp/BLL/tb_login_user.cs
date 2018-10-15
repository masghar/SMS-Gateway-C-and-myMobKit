using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessagingApp.BLL
{
    public partial class tb_login_user
    {
        AutoSMSDataContext dc = DBHandler.getDataContext();
        public List<tb_login_user> getUser(string name, string password)
        {
            var _user = from usr in dc.tb_login_users
                        where usr.user_name == name && usr.password==password
                        select usr;
            return _user.ToList();
        }
}
}
