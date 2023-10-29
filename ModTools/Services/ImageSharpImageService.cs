using System.Drawing.Imaging;
using System.Net.Mime;
using ModTools.Model;
using ModTools.Services.Contracts;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Advanced;
using SixLabors.ImageSharp.Formats.Png;
using Image = SixLabors.ImageSharp.Image;

namespace ModTools.Services;

public class ImageSharpImageService : IImageService
{
    public IImageService.ImageStats GetImageStats(string imagePath)
    {
        var imageInfo = Image.Identify(imagePath);
        var stats = new IImageService.ImageStats {Width = imageInfo.Width, Height = imageInfo.Height};
        return stats;
    }

    public IImageService.LoadResult LoadCitizenImage(string basePath, string raceName, string imageFileName, string currentFullPath, string raceInternalName)
    {
        var result = new IImageService.LoadResult();
        var filePath = string.IsNullOrWhiteSpace(currentFullPath) ? 
            basePath + string.Format(Constants.Race.RACE_CITIZEN_IMAGE_FOLDER, raceName) + imageFileName :
            currentFullPath;
        filePath = Path.GetFullPath(filePath);
        if (!File.Exists(filePath))
        {
            // Some citizen portraits are in dds format. Try this out first to see if that's why the file wasn't
            // found above.
            filePath = filePath.Replace(".png", ".dds");
            if (!File.Exists(filePath))
            {
                // Not dds, now check if it's humans, they use terran, as they have 2 factions
                if (raceName.Equals("Human"))
                {
                    filePath = basePath + string.Format(Constants.Race.RACE_CITIZEN_IMAGE_FOLDER, "Terran") + imageFileName;    
                }
                else
                {
                    // Must be one of the minor races, which all fall under the other folder
                    filePath = basePath + string.Format(Constants.Race.RACE_CITIZEN_IMAGE_FOLDER, "Other") + imageFileName;
                    if (!File.Exists(filePath))
                    {
                        // Last ditch effort, get the race from the internal name
                        var lastDitchRace = raceInternalName.Replace("Race_", "");
                        filePath = basePath + string.Format(Constants.Race.RACE_CITIZEN_IMAGE_FOLDER, lastDitchRace) +
                                   imageFileName;
                        if (!File.Exists(filePath))
                        {
                            // Ok, real last ditch effort due to irradiated having multiple races
                            var digits = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
                            lastDitchRace = lastDitchRace.TrimEnd(digits);
                            filePath = basePath + string.Format(Constants.Race.RACE_CITIZEN_IMAGE_FOLDER, lastDitchRace) +
                                       imageFileName;
                            if (!File.Exists(filePath))
                            {
                                // Default to "custom" image
                                filePath = basePath + Constants.Race.CUSTOM_CITIZEN_DEFAULT_PATH;
                            }
                        }
                    }
                }
            }
        }
        var path = Path.GetFullPath(filePath);
        result = LoadImage(path);
        return result;
    }

    public IImageService.LoadResult LoadImage(string path)
    {
        var result = new IImageService.LoadResult();
        if (path.Contains(".dds"))
        {
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            var newImage = new DDSImage(stream);
            using var mStream = new MemoryStream();
            newImage.BitmapImage.Save(mStream, ImageFormat.Png);
            mStream.Seek(0, SeekOrigin.Begin);
            path = Path.GetTempPath() + Path.GetFileNameWithoutExtension(path) + ".png";
            result.Image = newImage.BitmapImage;
            newImage.BitmapImage.Save(path);
        }
        else
        {
            var image2 = Image.Load(path);
            using var memStream = new MemoryStream();
            var encoder = image2.GetConfiguration().ImageFormatsManager.FindEncoder(PngFormat.Instance);
            image2.Save(memStream, encoder);
            var image = new Bitmap(memStream);
            path = Path.GetTempPath() + Path.GetFileNameWithoutExtension(path) + ".png";
            image2.Save(path);
            result.Image = image;
        }
        result.Path = path;
        return result;
    }

    public void ResizeImage(string loadPath, string? savePath, int width, int height)
    {
        savePath ??= loadPath;
        var image = Image.Load(loadPath);
        image.Mutate(x => x.Resize(width, height));
        image.Save(savePath);
        image.Dispose();
    }
}