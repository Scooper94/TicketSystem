using MVVM_Boilerplate.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.Models;
using TicketSystem.Notifications;

namespace TicketSystem.TicketDetail
{
    public class AddMessageCommand : CommandBase
    {
        #region Private Fields
        private ITicket _ticket;
        private IMessage _message;
        private INotificationSettings _newMessageNotificationSettings;
        private INotificationSender _notificationSender;
        #endregion
        #region Constructors
        public AddMessageCommand(ITicket ticket, IMessage message, INotificationSettings newMessageNotificationSettings, INotificationSender notificationSender)
        {
            _ticket = ticket;
            _message = message;
            _newMessageNotificationSettings = newMessageNotificationSettings;
            _notificationSender = notificationSender;
        }
        #endregion

        #region Methods
        public override void Execute(object? parameter)
        {
            _ticket.Messages.Add(_message);

            if (_newMessageNotificationSettings.NotifyCollaborators)
            {
                _notificationSender.SendNotification(_ticket.Owner, _ticket.Collaborators, _message);
            }
            else if (_newMessageNotificationSettings.NotifyOwner)
            {
                _notificationSender.SendNotification(_ticket.Owner, _message);
            }

            if (_newMessageNotificationSettings.NotifyAssignedAgent)
            {
                _notificationSender.SendNotification(_ticket.AssignedAgent, _message);
            }
        }

        public override bool CanExecute(object? parameter)
        {
            if (string.IsNullOrEmpty(_message.Contents))
                return false;

            return base.CanExecute(parameter);
        }
        #endregion
    }
}
