using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingApp.BLL
{
    public partial class tb_network_code
    {

        AutoSMSDataContext dc = DBHandler.getDataContext();

        public List<tb_network_code> getNetworkName(string code)
        {
            var _user = from tn in dc.tb_network_codes
                        where tn.code==code
                        select tn;
            return _user.ToList();
        }

       
    }
}
