using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.Models;

namespace TicketSystem.Notifications
{
    public interface INotificationSender
    {
        void SendNotification(IUser recipient, List<IUser> copyRecipients, IMessage contents);
        void SendNotification(IUser recipient, IMessage contents);
    }
}
