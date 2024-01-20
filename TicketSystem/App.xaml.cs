using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVVM_Boilerplate.Base;
using MVVM_Boilerplate.Navigation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TicketSystem.NavigationBar;
using TicketSystem.NavigationCommands;
using TicketSystem.Settings;
using TicketSystem.TicketDetail;
using TicketSystem.TicketList;

namespace TicketSystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IHost? AppHost { get; private set; }

        public App()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) => 
                {
                    services.AddSingleton<MainWindow>(provider => new MainWindow
                    {
                        DataContext = provider.GetRequiredService<MainWindowViewModel>()
                    });
                    services.AddSingleton<MainWindowViewModel>(provider => CreateMainWindowViewModel());                   
                    services.AddTransient<SettingsViewModel>(provider => CreateSettingsViewModel());
                    services.AddTransient<NavigationBarViewModel>(provider => CreateNavigationViewModel());

                    services.AddScoped<NavigationStore>();
                    
                    services.AddTransient<INavigationService<SettingsViewModel>>(provider => CreateNavigationService<SettingsViewModel>());
                    services.AddTransient<INavigationService<TicketListViewModel>, NavigationService<TicketListViewModel>>();
                    services.AddTransient<NavigateCommand<SettingsViewModel>>(provider => CreateNavigateCommand<SettingsViewModel>());
                    services.AddTransient<NavigateCommand<TicketListViewModel>> (provider => CreateNavigateCommand<TicketListViewModel>());

                    services.AddTransient<Func<SettingsViewModel>>(provider => () => CreateSettingsViewModel());
                    services.AddTransient<Func<TicketListViewModel>>(provider => () => CreateTicketListViewModel());
                })
                .Build();
        }
        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost!.StartAsync();

            var window = AppHost.Services.GetRequiredService<MainWindow>();
            window.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost!.StopAsync();
            base.OnExit(e);
        }

        private MainWindowViewModel CreateMainWindowViewModel()
        {
            return new MainWindowViewModel(
                AppHost!.Services.GetRequiredService<NavigationBarViewModel>()
                , AppHost!.Services.GetRequiredService<NavigationStore>()
                );
        }

        private SettingsViewModel CreateSettingsViewModel()
        {
            return new SettingsViewModel();
        }

        private TicketListViewModel CreateTicketListViewModel()
        {
            return new TicketListViewModel();
        }

        private NavigateCommand<TViewModel> CreateNavigateCommand<TViewModel>() where TViewModel : ViewModelBase
        {
            return new NavigateCommand<TViewModel>(AppHost!.Services.GetRequiredService<INavigationService<TViewModel>>());
        }

        private NavigationService<TViewModel> CreateNavigationService<TViewModel>() where TViewModel : ViewModelBase
        {
            return new NavigationService<TViewModel>(AppHost!.Services.GetRequiredService<NavigationStore>(), AppHost!.Services.GetRequiredService<Func<TViewModel>>());
        }

        private NavigationBarViewModel CreateNavigationViewModel()
        {
            return new NavigationBarViewModel(
                AppHost!.Services.GetRequiredService<NavigateCommand<SettingsViewModel>>()
                , AppHost!.Services.GetRequiredService<NavigateCommand<TicketListViewModel>>()
                , AppHost!.Services.GetRequiredService<NavigateCommand<TicketListViewModel>>());
        }
    }
}
