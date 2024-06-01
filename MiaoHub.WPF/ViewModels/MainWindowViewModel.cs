using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MiaoHub.WPF.Models;
using MiaoHub.WPF.Services;
using MiaoHub.WPF.Config;
using Microsoft.Extensions.Configuration;

namespace MiaoHub.WPF.ViewModels
{
    public partial class MainWindowViewModel:ObservableObject
    {
        private readonly ConfigService _configService;

        public MainWindowViewModel(ConfigService configService)
        {
            _configService = configService;
            var config = _configService.GetConfig<AllConfigOption>();
        }

    }
}
