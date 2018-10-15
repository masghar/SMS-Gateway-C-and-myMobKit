using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingApp.Model
{
    public class DeviceMessage : BaseMessage
    {

        public string MessageType { get; set; }

        public string Receiver { get; set; }

        public string Sender { get; set; }

        public string ThreadId { get; set; }

        public bool Read { get; set; }


        override public string ToString()
        {
            string str = String.Empty;
            str = String.Concat(str, "Date = ", Date, "\r\n");
            str = String.Concat(str, "Id = ", Id, "\r\n");
            str = String.Concat(str, "Message = ", Message, "\r\n");
            str = String.Concat(str, "Number = ", Number, "\r\n");
            str = String.Concat(str, "MessageType = ", MessageType, "\r\n");
            str = String.Concat(str, "Receiver = ", Receiver, "\r\n");
            str = String.Concat(str, "Sender = ", Sender, "\r\n");
            str = String.Concat(str, "ThreadId = ", ThreadId, "\r\n");
            str = String.Concat(str, "Read = ", Read, "\r\n");
            return str;
        }

    }
}
