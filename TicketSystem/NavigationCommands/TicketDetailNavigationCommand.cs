using MVVM_Boilerplate.Base;
using MVVM_Boilerplate.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.Models;
using TicketSystem.TicketDetail;

namespace TicketSystem.NavigationCommands
{
    public class TicketDetailNavigationCommand : CommandBase
    {
        private IParameterNavigationService<ITicket, TicketDetailViewModel> _navigationService;

        public TicketDetailNavigationCommand(IParameterNavigationService<ITicket, TicketDetailViewModel> navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object? parameter)
        {
            var ticket = (ITicket)parameter!;
            _navigationService.Navigate(ticket);
        }
    }
}
