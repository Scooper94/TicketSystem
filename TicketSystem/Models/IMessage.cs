using System;

namespace TicketSystem.Models
{
    public interface IMessage
    {
        string Contents { get; set; }
        DateTime CreatedDate { get; set; }
        int Id { get; set; }
        IMessageSender Sender { get; set; }
    }
}