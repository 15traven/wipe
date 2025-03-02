using CommunityToolkit.Mvvm.ComponentModel;
using Wipe.Contracts.ViewModels;

namespace Wipe.ViewModels;

public partial class MainViewModel : ObservableRecipient, INavigationAware
{
    public long FilesSize
    {
        get; private set;
    }

    public MainViewModel()
    {
    }

    public void OnNavigatedTo(object parameter)
    {
        if (parameter is long filesSize)
        {
            FilesSize = filesSize;
        }
    }

    public void OnNavigatedFrom() => throw new NotImplementedException();
}
