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
                    services.AddSingleton<MainWindow>();
                    services.AddScoped<NavigationStore>();
                    services.AddTransient<SettingsViewModel>();
                    services.AddTransient<Func<SettingsViewModel>>(x => () => x.GetRequiredService<SettingsViewModel>());
                    services.AddTransient<INavigationService<SettingsViewModel>, NavigationService<SettingsViewModel>>();
                })
                .Build();
        }
        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost!.StartAsync();

            var window = AppHost.Services.GetRequiredService<MainWindow>();

            var s = AppHost.Services.GetRequiredService<INavigationService<SettingsViewModel>>();

            //var window = new MainWindow();
            /*window.DataContext = new MainWindowViewModel(
                new NavigationBarViewModel(
                    new NavigateSettingsCommand(
                        AppHost.Services.GetRequiredService<INavigationService<SettingsViewModel>>()
                    )
                );*/
            window.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost.StopAsync();
            base.OnExit(e);
        }
    }
}
