﻿using MVVM_Boilerplate.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.Models;

namespace TicketSystem.TicketList
{
    public class TicketListViewModel : ViewModelBase
    {
        #region Properties
        public ObservableCollection<ITicket> TicketList { get; private set; }
        #endregion

        public TicketListViewModel(ObservableCollection<ITicket> ticketList)
        {
            TicketList = ticketList;
        }
    }
}
