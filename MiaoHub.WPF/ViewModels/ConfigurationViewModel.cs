using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using MiaoHub.WPF.Config;
using MiaoHub.WPF.Models;
using MiaoHub.WPF.Services;

namespace MiaoHub.WPF.ViewModels
{
    public partial class ConfigurationViewModel:ObservableObject
    {
        private readonly ConfigService _configService;
        public AccountConfigOption? AccountConfig { get; private set; }


        [ObservableProperty]
        public string? username;
        [ObservableProperty]
        public string[]? mode = { "离线登录", "正版登录", "第三方登录" };
        [ObservableProperty]
        public string? selectedMode = "离线登录";

        public ConfigurationViewModel(ConfigService configService)
        {
            _configService = configService;
            AccountConfig =_configService.GetConfig<AccountConfigOption>("AllConfig:AccountConfig");
            ReadConfig();
        }

        public void ReadConfig()
        {
            Username = AccountConfig?.UserName;
            SelectedMode = AccountConfig?.SelectedMode;
        }





    }
}
