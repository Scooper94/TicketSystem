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
    }
}
