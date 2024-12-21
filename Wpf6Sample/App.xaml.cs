
using System.Windows;
using Wpf6Sample.Views;


namespace Wpf6Sample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
public partial class App : Application
{
    void Application_Startup(object sender, StartupEventArgs e)
    {
        var wnd = new MainWindow();
        wnd.Show();
    }
}

}
