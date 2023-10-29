namespace ModTools.Services.Contracts;

public interface IImageService
{

    LoadResult LoadCitizenImage(string basePath, string raceName, string imageFileName, string currentFullPath, string raceInternalName);
    LoadResult LoadImage(string path);
    ImageStats GetImageStats(string imagePath);
    void ResizeImage(string loadPath, string? savePath, int width, int height);
    
    
    public class LoadResult
    {
        public Image Image { get; set; }
        public string Path { get; set; }
    }

    public class ImageStats
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}