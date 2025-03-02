using CommunityToolkit.Mvvm.ComponentModel;
using Wipe.Helpers;

namespace Wipe.ViewModels;

public partial class AnalyzingViewModel : ObservableRecipient
{
    private readonly FilesAnalyzer filesAnalyzer;
    public long FilesSize
    {
        get; private set;
    }

    public AnalyzingViewModel()
    {
        filesAnalyzer = new FilesAnalyzer();
    }

    public async Task AnalyzeFilesAsync()
    {
        FilesSize = await filesAnalyzer.AnalyzeFilesAsync();
    }
}
