using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MiaoHub.WPF.Config
{
    public partial class AllConfigOption :ObservableObject
    {
        public const string AllConfig = "AllConfig";

        [ObservableProperty]
        public string? appTitle;
        [ObservableProperty]
        public string? appVersion;
        [ObservableProperty]
        public string? appDescription;


        public AccountConfigOption AccountConfig { get; set; } = new();
    }
}
