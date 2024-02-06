using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicketSystem.TicketList
{
    /// <summary>
    /// Interaction logic for TicketListView.xaml
    /// </summary>
    public partial class TicketListView : UserControl
    {
        public TicketListView()
        {
            InitializeComponent();
        }

        //TODO: Improve
        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dc = DataContext as TicketListViewModel;
            dc.OpenTicketDetailCommand.Execute(dc.SelectedTicket);
        }
    }
}
