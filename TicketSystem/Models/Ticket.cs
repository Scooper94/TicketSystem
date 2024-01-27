using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.Models;

namespace TicketSystem.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string IssueDescription { get; set; }
        public List<IMessage> Messages { get; set; }

        public IUser Owner { get; set; }

        /*
         * Due Date
         * Opened By
         * Assigned To
         * Priority
         * Status
         * Description
         * Collaborators
         * Owner
         * Messages
         * --Recurring Task?--
         */
    }
}
