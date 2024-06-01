using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaoHub.WPF.Models
{
    public class AccountConfiguration
    {
        public string? Username { get; set; }
        public LoginMode LoginMode { get; set; }  = LoginMode.Offline;
     
    }
    public enum LoginMode
    {
        Offline,
        Normal,
        ThirdParty
    }
}
