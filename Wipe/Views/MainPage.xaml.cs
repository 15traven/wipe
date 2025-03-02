using Microsoft.UI.Xaml.Controls;

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

        FilesSizeText.Text = ViewModel.FilesSize.ToString();
    }
}
