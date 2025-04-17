using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace AvaloniaAppTemplate;

public partial class App : Application
{
    public override void Initialize() =>
        FluentThemePack.DefaultTheme.ApplyTheme(this);

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainView();
        }

        base.OnFrameworkInitializationCompleted();
    }
}
