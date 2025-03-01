using Microsoft.UI.Xaml.Controls;

using Wipe.ViewModels;

namespace Wipe.Views;

public sealed partial class ResultsPage : Page
{
    public ResultsViewModel ViewModel
    {
        get;
    }

    public ResultsPage()
    {
        ViewModel = App.GetService<ResultsViewModel>();
        InitializeComponent();
    }
}
