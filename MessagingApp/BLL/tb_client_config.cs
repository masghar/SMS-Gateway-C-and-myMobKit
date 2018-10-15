using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingApp.BLL
{
   public partial class tb_client_config
    {

        AutoSMSDataContext dc = DBHandler.getDataContext();

        public List<tb_client_config> LoadConfig()
        {
            var _user = from usr in dc.tb_client_configs
                        select usr;
            return _user.ToList();
        }
    }
}
