using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingApp.Model
{
    public class Message: BaseMessage
    {
        public string To { get; set; }

        override public string ToString()
        {
            string str = String.Empty;
            str = String.Concat(str, "Date = ", Date, "\r\n");
            str = String.Concat(str, "Id = ", Id, "\r\n");
            str = String.Concat(str, "Message = ", Message, "\r\n");
            str = String.Concat(str, "Number = ", Number, "\r\n");
            str = String.Concat(str, "To = ", To, "\r\n");
            return str;
        }
    }
}
