using Avalonia.Controls;
namespace AvaloniaAppTemplate;

public class MainView : Window
{
    public MainView()
    {
    	Title = "AvaloniaAppTemplate";
        Content = new StackPanel()
        {
            Children = 
            {
	            new TextBlock()
    	        {
        	    	Text = "Hello from NoXaml",
            		HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
            		VerticalAlignment = Avalonia.Layout.VerticalAlignment.Top,
            		FontSize = 35,
            	},
            }
        };
    }
}
