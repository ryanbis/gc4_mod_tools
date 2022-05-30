namespace ModTools.View.Contracts;

public interface IRequestFolderView
{
    RequestFolderResult RequestFolder();
    RequestFolderResult RequestFolder(string? path);
    
    public class RequestFolderResult
    {
        public string? Path { get; set; }
        public bool Canceled { get; set; }
    }
}