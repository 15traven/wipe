using Microsoft.UI.Xaml.Controls;
using Wipe.Contracts.Services;
using Wipe.Helpers;
using Wipe.Services;
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

        AnalyzeFiles();
    }

    private async void AnalyzeFiles()
    {
        await ViewModel.AnalyzeFilesAsync();
        var navigationService = App.GetService<INavigationService>();
        navigationService.NavigateTo("Wipe.ViewModels.MainViewModel", ViewModel.FilesSize);
    }
}
