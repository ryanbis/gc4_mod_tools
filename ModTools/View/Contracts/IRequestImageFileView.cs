namespace ModTools.View.Contracts;

public interface IRequestImageFileView
{
    RequestFileResult RequestImageFile(bool multiSelect = false);
    
    public class RequestFileResult
    {
        public string? Path { get; set; }
        
        public string[]? Paths { get; set; }
        public bool Canceled { get; set; }
    }
}