namespace Wipe.Helpers;

internal class FilesAnalyzer
{
    private readonly string tempPath = Path.GetTempPath();

    public async Task<long> AnalyzeFilesAsync()
    {
        return await Task.Run(() =>
        {
            if (!Directory.Exists(tempPath))
                return 0;

            return Directory.GetFiles(tempPath, "*", SearchOption.AllDirectories)
                .Sum(file => new FileInfo(file).Length);
        });
    }
}
