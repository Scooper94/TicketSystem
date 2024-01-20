using MVVM_Boilerplate.Base;
using MVVM_Boilerplate.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Private Fields
        private NavigationStore _mainViewModelNavigationStore;
        #endregion

        #region Constructors
        public MainWindowViewModel(ViewModelBase leftPanelViewModel, NavigationStore mainViewModelNavigationStore)
        {
            LeftPanelViewModel = leftPanelViewModel;
            _mainViewModelNavigationStore = mainViewModelNavigationStore;
            _mainViewModelNavigationStore.ViewModelChanged += OnMainViewModelChanged;

        }
        #endregion

        #region Properties
        public ViewModelBase HeaderViewModel { get; set; }
        public ViewModelBase MainViewModel => _mainViewModelNavigationStore.CurrentViewModel;
        public ViewModelBase LeftPanelViewModel { get; set; }
        public ViewModelBase ModalViewModel { get; set; }
        #endregion

        #region Methods
        private void OnMainViewModelChanged(object c, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(nameof(MainViewModel));
        }
        #endregion
    }
}
