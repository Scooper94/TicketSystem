using MVVM_Boilerplate.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Private Fields
        #endregion

        #region Constructors
        public MainWindowViewModel(ViewModelBase leftPanelViewModel)
        {
            LeftPanelViewModel = leftPanelViewModel;
        }
        #endregion

        #region Properties
        public ViewModelBase HeaderViewModel { get; set; }
        public ViewModelBase MainViewModel { get; set; }
        public ViewModelBase LeftPanelViewModel { get; set; }
        public ViewModelBase ModalViewModel { get; set; }
        #endregion
    }
}
