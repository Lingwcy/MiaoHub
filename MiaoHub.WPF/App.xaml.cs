
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Configuration;
using System.Data;
using System.Windows;

namespace MiaoHub.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IHost _host;
        protected override async void OnStartup(StartupEventArgs e)
        {
            _host = await MiaoHost.Start();
            base.OnStartup(e);
        }


        public ILogger<T> GetLogger<T>()
        {
            return _host.Services.GetService<ILogger<T>>()!;
        }
        public T? GetService<T>() where T : class
        {
            return _host.Services.GetService(typeof(T)) as T;
        }
        public object? GetService(Type type)
        {
            return _host.Services.GetService(type);
        }

    }

}
