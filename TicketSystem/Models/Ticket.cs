using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.Models;

namespace TicketSystem.Models
{
    public class Ticket : ITicket
    {
        public int Id { get; private set; }
        public string Title { get; set; }
        public string IssueDescription { get; set; }
        public List<IMessage> Messages { get; private set; }
        public IUser Owner { get; set; }
        public IUser AssignedAgent { get; set; }
        public List<IUser> Collaborators { get; private set; }
        public TicketStatuses Status { get; set; }
        public PriorityLevels Priority { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public DateTime DueDate { get; set; }

        public Ticket(List<IUser> collaborators, List<IMessage> messages, int id)
        {
            Messages = messages;
            Collaborators = collaborators;
            Id = id;
        }
    }
}
