using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem.Models
{
    public class Message : IMessage
    {
        public int Id { get; set; }
        public string Contents { get; set; }
        public DateTime CreatedDate { get; set; }
        public IMessageSender Sender { get; set; }

    }
}
