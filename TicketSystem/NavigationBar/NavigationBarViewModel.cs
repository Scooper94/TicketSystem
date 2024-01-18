using MVVM_Boilerplate.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TicketSystem.NavigationBar
{
    public class NavigationBarViewModel : ViewModelBase
    {
        public NavigationBarViewModel(ICommand navigateSettingsCommand, ICommand navigateOpenTicketsCommad)
        {
            NavigateSettingsCommand = navigateSettingsCommand;
            NavigateOpenTicketsCommad = navigateOpenTicketsCommad;
        }
        #region Private Fields

        #endregion

        #region Constructors

        #endregion

        #region Properties
        public ICommand NavigateSettingsCommand { get; set; }
        public ICommand NavigateOpenTicketsCommad { get; set; }
        #endregion
    }
}
