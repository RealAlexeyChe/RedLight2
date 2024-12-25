using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;
using System.Threading;
using System.Threading.Tasks;

namespace RedLight.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }
    
    private void ClickHandler(object sender, RoutedEventArgs args)
    {
        
        Lamp.IsVisible = true;

        Task.Run(() =>
        {
            Thread.Sleep(1000);

            Dispatcher.UIThread.Invoke(() =>
            {
                Lamp.IsVisible = false;
            });

        });
    }
}
