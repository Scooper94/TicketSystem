using System;
using System.Collections.Generic;

namespace TicketSystem.Models
{
    public interface ITicket
    {
        IUser AssignedAgent { get; set; }
        List<IUser> Collaborators { get; }
        DateTime CreatedDate { get; set; }
        DateTime DueDate { get; set; }
        int Id { get; }
        string IssueDescription { get; set; }
        DateTime LastUpdatedDate { get; set; }
        List<IMessage> Messages { get; }
        IUser Owner { get; set; }
        PriorityLevels Priority { get; set; }
        TicketStatuses Status { get; set; }
        string Title { get; set; }
    }
}