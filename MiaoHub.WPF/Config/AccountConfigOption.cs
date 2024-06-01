using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MiaoHub.WPF.Config
{
    public partial class AccountConfigOption :ObservableObject
    {
        public const string AccountConfig = "AccountConfig";
        [ObservableProperty]
        public string? userName;

        [ObservableProperty]
        public string? selectedMode;
    }
}
