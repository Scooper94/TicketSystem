using MVVM_Boilerplate.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.Models;

namespace TicketSystem.TicketDetail
{
    public class TicketDetailViewModel : ViewModelBase
    {
        private ITicket _ticket;

        public TicketDetailViewModel(ITicket ticket)
        {
            _ticket = ticket;
        }

        #region Properties
        public string TicketID => "#" + _ticket.Id.ToString();
        public string Title => _ticket.Title;
        public string Description => _ticket.IssueDescription;
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
