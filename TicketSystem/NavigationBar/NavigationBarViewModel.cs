using MVVM_Boilerplate.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TicketSystem.NavigationBar
{
    public class NavigationBarViewModel : ViewModelBase, INavigationBarViewModel
    {
        public NavigationBarViewModel(ICommand navigateSettingsCommand, ICommand navigateOpenTicketsCommand, ICommand navigateClosedTicketsCommand)
        {
            NavigateSettingsCommand = navigateSettingsCommand;
            NavigateOpenTicketsCommand = navigateOpenTicketsCommand;
            NavigateClosedTicketsCommand = navigateClosedTicketsCommand;
        }
        #region Private Fields

        #endregion

        #region Constructors

        #endregion

        #region Properties
        public ICommand NavigateSettingsCommand { get; set; }
        public ICommand NavigateOpenTicketsCommand { get; set; }
        public ICommand NavigateClosedTicketsCommand { get; set; }
        #endregion
    }
}
