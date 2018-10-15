using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingApp.Model
{
    class PutMessageResponce : BaseResponse
    {
        public Message Message { get; set; }
        public string count { get; set; }

        override public string ToString()
        {
            string str = String.Empty;
            str = String.Concat(str, "RequestMethod = ", RequestMethod, "\r\n");
            str = String.Concat(str, "Description = ", Description, "\r\n");
            str = String.Concat(str, "IsSuccessful = ", IsSuccessful, "\r\n");
            str = String.Concat(str, "Message = ", Message, "\r\n");
            str = String.Concat(str, "Count = ", count, "\r\n");

            return str;
        }
    }
}
