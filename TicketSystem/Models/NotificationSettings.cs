using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem.Models
{
    public class NotificationSettings : INotificationSettings
    {
        public bool NotifyOwner { get; set; }
        public bool NotifyCollaborators { get; set; }
        public bool NotifyAssignedAgent { get; set; }
        public bool NotifyAllAgents { get; set; }
    }
}
