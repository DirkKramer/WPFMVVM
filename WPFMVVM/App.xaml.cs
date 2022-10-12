global using CommunityToolkit.Mvvm;
global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;
global using System;
global using System.Collections.Generic;
global using System.Configuration;
global using System.Data;
global using System.Linq;
global using System.Threading.Tasks;
global using System.Windows;
global using WPFMVVM.ViewModels;
global using WPFMVVM.Views;
global using WPFMVVM.Services;
global using WPFMVVM.Models;
using Microsoft.Extensions.DependencyInjection;

namespace WPFMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public ServiceProvider serviceProvider;
        public App()
        {
            ServiceCollection serviceDescriptors = new ServiceCollection();
            serviceDescriptors.AddSingleton<MainWindow>();
            serviceDescriptors.AddSingleton<DatabaseService>();
            serviceDescriptors.AddSingleton<MainViewModel>();
            serviceDescriptors.AddScoped<CostumerViewModel>();
            serviceDescriptors.AddScoped<CostumerWindow>();


            serviceProvider = serviceDescriptors.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainwindow = serviceProvider.GetService<MainWindow>();
            mainwindow.ShowDialog();
        }
    }
}
