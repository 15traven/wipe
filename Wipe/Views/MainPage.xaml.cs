using System.Reflection.Metadata;
using System.Text;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using Wipe.ViewModels;

namespace Wipe.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
        DisplayFilesSize((long)e.Parameter);
    }

    private void DisplayFilesSize(long filesSize)
    {
        string[] sizes = { "B", "KB", "MB", "GB" };
        var order = 0;
        while (filesSize >= 1024 && order < sizes.Length - 1)
        {
            order++;
            filesSize /= 1024;
        }

        FilesSizeText.Text = string.Format("{0:0.##} {1}", filesSize, sizes[order]);
    }
}
