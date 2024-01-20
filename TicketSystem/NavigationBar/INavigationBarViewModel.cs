using MVVM_Boilerplate.Base;
using System.Windows.Input;

namespace TicketSystem.NavigationBar
{
    public interface INavigationBarViewModel
    {
        ICommand NavigateOpenTicketsCommand { get; set; }
        ICommand NavigateSettingsCommand { get; set; }
        ICommand NavigateClosedTicketsCommand { get; set; }
        
    }
}