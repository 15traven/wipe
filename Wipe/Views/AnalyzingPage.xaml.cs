using Microsoft.UI.Xaml.Controls;

using Wipe.ViewModels;

namespace Wipe.Views;

public sealed partial class AnalyzingPage : Page
{
    public AnalyzingViewModel ViewModel
    {
        get;
    }

    public AnalyzingPage()
    {
        ViewModel = App.GetService<AnalyzingViewModel>();
        InitializeComponent();
    }
}
