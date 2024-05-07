using Avalonia.Controls;
using Avalonia.ReactiveUI;
namespace AvaloniaAppTemplate;

public class MainView : ReactiveUserControl<MainViewModel>
{
    public MainView()
    {
    	Title = "AvaloniaAppTemplate";
        Content = new StackPanel()
        {
            Children = 
            new TextBlock()
            {
            	Text = "Hello from NoXaml",
            	HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
            	VerticalAlignment = Avalonia.Layout.VerticalAlignment.Top,
            	FontSize = 35,
            }
        };
    }
}
