using System;
using System.Reflection;
using Avalonia.ReactiveUI;
using AvaloniaTest.ViewModels;

namespace AvaloniaTest.Views;

public class MainWindow : ReactiveWindow<ViewModelBase>
{
    public MainWindow()
    {
        Title = "AvaloniaTest";
        Content = new MainView();
        Icon = new(
            Assembly
            .GetExecutingAssembly()
            .GetManifestResourceStream("iconfile")
            ?? throw new ArgumentException("Icon file could not be loaded"));
    }
}
