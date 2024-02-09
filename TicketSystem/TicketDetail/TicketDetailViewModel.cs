using MVVM_Boilerplate.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.Models;

namespace TicketSystem.TicketDetail
{
    public class TicketDetailViewModel : ViewModelBase
    {
        private ITicket _ticket;

        public TicketDetailViewModel(ITicket ticket, ObservableCollection<IUser> availableAgents)
        {
            _ticket = ticket;
            AvailableAgents = availableAgents;
        }

        #region Properties
        public string TicketID => "#" + _ticket.Id.ToString();
        public string Title => _ticket.Title;
        public string Description => _ticket.IssueDescription;
        public string CreatedUser => _ticket.Owner.Name;
        public ObservableCollection<IUser> AvailableAgents { get; set; }
        public IUser AssignedAgent
        {
            get
            {
                return _ticket.AssignedAgent;
            }
            set
            {
                if (_ticket.AssignedAgent != value)
                    return;
                _ticket.AssignedAgent = value;
                OnPropertyChanged(nameof(AssignedAgent));
            }
        }
        public DateTime DueDate
        {
            get
            {
                return _ticket.DueDate;
            }
            set
            {
                _ticket.DueDate = value;
                OnPropertyChanged(nameof(DueDate));
            }
        }
        #endregion
    }
}
