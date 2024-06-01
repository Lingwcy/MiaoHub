using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MiaoHub.WPF.ViewModels;

namespace MiaoHub.WPF.Views.Pages
{
    /// <summary>
    /// ConfigurationPage.xaml 的交互逻辑
    /// </summary>
    public partial class ConfigurationPage : Page
    {
        public ConfigurationViewModel ViewModel { get; set; }
        public ConfigurationPage(ConfigurationViewModel ViewModel)
        {
            InitializeComponent();
            this.ViewModel = ViewModel;
            DataContext = ViewModel;
            
        }
    }
}
