using ModTools.View.Contracts;

namespace ModTools.View;

public class RequestFolderView :  IRequestFolderView
{
    public IRequestFolderView.RequestFolderResult RequestFolder()
    {
        var result = new IRequestFolderView.RequestFolderResult();
        var dialog = new FolderBrowserDialog();
        if (dialog.ShowDialog() != DialogResult.OK || string.IsNullOrWhiteSpace(dialog.SelectedPath))
        {
            result.Path = "";
            result.Canceled = true;
        }
        else
        {
            result.Path = dialog.SelectedPath;
        }
        return result;
    }
    
    public IRequestFolderView.RequestFolderResult RequestFolder(string? path)
    {
        var result = new IRequestFolderView.RequestFolderResult();
        var dialog = new FolderBrowserDialog();
        dialog.SelectedPath = path;
        if (dialog.ShowDialog() != DialogResult.OK || string.IsNullOrWhiteSpace(dialog.SelectedPath))
        {
            result.Path = "";
            result.Canceled = true;
        }
        else
        {
            result.Path = dialog.SelectedPath;
        }
        return result;
    }
}