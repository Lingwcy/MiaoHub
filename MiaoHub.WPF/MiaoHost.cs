using BetterGenshinImpact.Service;
using MiaoHub.WPF.Helpers.Extensions;
using MiaoHub.WPF.Models;
using MiaoHub.WPF.ViewModels;
using MiaoHub.WPF.Views.Pages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MiaoHub.WPF.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Ui;

namespace MiaoHub.WPF
{
    public static class MiaoHost
    {
        private static IHost? _host;

        private static IHost CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                 .ConfigureHostConfiguration(hostConfig =>
                 {
                     hostConfig.AddJsonFile("appsettings.json", optional: true);
                 })
                .ConfigureServices((hostContext, services) =>
                {
                    // 注册WPF应用宿主服务
                    services.AddHostedService<ApplicationHostService>();
                    services.AddSingleton<ConfigService>();

                    // 注册页面解析服务
                    services.AddSingleton<INavigationService, NavigationService>();

                    // 注册主窗口和导航
                    services.AddView<INavigationWindow, MainWindow, MainWindowViewModel>();

                    // 注册视图
                    services.AddView<HomePage, HomePageViewModel>();
                    services.AddView<ConfigurationPage, ConfigurationViewModel>();

                })
                .Build();

        public static async Task<IHost> Start()
        {
            _host = CreateHostBuilder();
            await _host.StartAsync();
            return _host;
        }
    }

}
