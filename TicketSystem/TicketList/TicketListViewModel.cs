using MVVM_Boilerplate.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TicketSystem.Models;

namespace TicketSystem.TicketList
{
    public class TicketListViewModel : ViewModelBase
    {
        #region Private Fields

        #endregion
        #region Properties
        public ObservableCollection<ITicket> TicketList { get; private set; }
        public ICommand OpenTicketDetailCommand { get; private set; }
        public ITicket SelectedTicket { get; set; }

        #endregion

        public TicketListViewModel(ObservableCollection<ITicket> ticketList, ICommand openTicketDetailCommand)
        {
            TicketList = ticketList;
            OpenTicketDetailCommand = openTicketDetailCommand;
        }
    }
}
