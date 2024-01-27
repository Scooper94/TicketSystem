using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem.Models
{
    public interface IMessageSender
    {
        string Name { get; set; }
        string EmailAddress { get; set; }
    }
}
