namespace TicketSystem.Models
{
    public interface IUser : IMessageSender
    {
        UserRoles Role { get; set; }
    }
}