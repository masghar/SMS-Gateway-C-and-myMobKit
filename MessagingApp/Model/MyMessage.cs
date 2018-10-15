using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingApp.Model
{
    public abstract class MyMessage
    {

        public string Date { get; set; }

        public string Id { get; set; }

        public string MessageText { get; set; }

        public string Number { get; set; }
        public string To { get; set; }
        public string MessageType { get; set; }

        public string Receiver { get; set; }

        public string Sender { get; set; }

        public string ThreadId { get; set; }

        public bool Read { get; set; }

    }
}
