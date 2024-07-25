using Avalonia.Controls;
using Avalonia.ReactiveUI;
using AvaloniaTest.ViewModels;
namespace AvaloniaTest.Views;

public class MainView : ReactiveUserControl<MainViewModel>
{
    public MainView()
    {
        TextBlock block = new()
        {
            Text = "Hello from NoXaml",
            HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Top,
            FontSize = 35,
        };
        Content = new StackPanel()
        {
            Children = { block }
        };
    }
}
