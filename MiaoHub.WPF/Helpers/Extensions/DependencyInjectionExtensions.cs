
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Controls;

namespace MiaoHub.WPF.Helpers.Extensions;

internal static class DependencyInjectionExtensions
{
    public static IServiceCollection AddView<TWindow, TWindowImplementation, TViewModel>(this IServiceCollection services)
        where TWindow : class
        where TWindowImplementation : class, TWindow
        where TViewModel : class
    {
        return services
            .AddSingleton<TWindow, TWindowImplementation>()
            .AddSingleton<TViewModel>();
    }

    public static IServiceCollection AddView<TPage, TViewModel>(this IServiceCollection services)
        where TPage : Page
        where TViewModel : class
    {
        return services
            .AddSingleton<TPage>()
            .AddSingleton<TViewModel>();
    }
}