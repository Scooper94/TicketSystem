using MVVM_Boilerplate.Base;
using MVVM_Boilerplate.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.Settings;

namespace TicketSystem.NavigationCommands
{
    public class NavigateSettingsCommand : CommandBase
    {
        private NavigationService<SettingsViewModel> _settingsNavigationService;
        public NavigateSettingsCommand(NavigationService<SettingsViewModel> settingsNavigationService)
        {
            _settingsNavigationService = settingsNavigationService;
        }
        public override void Execute(object? parameter)
        {
            _settingsNavigationService.Navigate();
        }
    }
}
