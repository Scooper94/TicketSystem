namespace TicketSystem.Models
{
    public interface INotificationSettings
    {
        bool NotifyAllAgents { get; set; }
        bool NotifyAssignedAgent { get; set; }
        bool NotifyCollaborators { get; set; }
        bool NotifyOwner { get; set; }
    }
}