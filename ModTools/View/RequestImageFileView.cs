using ModTools.View.Contracts;

namespace ModTools.View;

public class RequestImageFileView : IRequestImageFileView
{
    public IRequestImageFileView.RequestFileResult RequestImageFile(bool multiSelect)
    {
        var result = new IRequestImageFileView.RequestFileResult();
        var dialog = new OpenFileDialog();
        dialog.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|dds files (*.dds)|*.dds";
        dialog.FilterIndex = 1;
        dialog.Multiselect = multiSelect;
        if (dialog.ShowDialog() != DialogResult.OK || (string.IsNullOrWhiteSpace(dialog.FileName) && dialog.FileNames.Length == 0))
        {
            result.Path = "";
            result.Canceled = true;
        }
        else
        {
            if (multiSelect)
            {
                result.Paths = dialog.FileNames;
            }
            else
            {
                result.Path = dialog.FileName;                
            }
        }
        return result;
    }
}