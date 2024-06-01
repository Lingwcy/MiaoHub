using MiaoHub.WPF.ViewModels;
using Wpf.Ui;
using Wpf.Ui.Controls;

namespace MiaoHub.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FluentWindow,INavigationWindow
    {
        public MainWindowViewModel ViewModel { get; }
        public MainWindow(INavigationService navigationService, MainWindowViewModel viewModel)
        {
            InitializeComponent();
            DataContext = ViewModel = viewModel;
            navigationService.SetNavigationControl(RootNavigation);
        }

        public INavigationView GetNavigation()
        {
            return RootNavigation;
        }

        public bool Navigate(Type pageType)
        {
            return RootNavigation.Navigate(pageType);
        }

        public void SetServiceProvider(IServiceProvider serviceProvider)
        {
            throw new NotImplementedException();
        }

        public void SetPageService(IPageService pageService)
        {
            throw new NotImplementedException();
        }

        public void ShowWindow()
        {
            Show();
        }

        public void CloseWindow()
        {
            Close();
        }
    }
}