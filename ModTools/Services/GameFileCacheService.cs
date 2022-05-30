using System.Xml;
using System.Xml.Serialization;
using ModTools.Model;
using ModTools.Services.Contracts;

namespace ModTools.Services;

public class GameFileCacheService : IGameFileCacheService
{

    private readonly Dictionary<string, IXmlModel> GameFileCache = new();

    public T GetGameFile<T>(string filePath) where T : IXmlModel
    {
        if (GameFileCache.ContainsKey(filePath)) return (T) GameFileCache[filePath];
        
        var xmlDoc = new XmlDocument {PreserveWhitespace = true};
        xmlDoc.Load(filePath);
        XmlReader raceReader = new XmlNodeReader(xmlDoc);
        var raceSerializer = new XmlSerializer(typeof(T));
        var gameFile = (T) raceSerializer.Deserialize(raceReader);
        GameFileCache[filePath] = gameFile;
        return gameFile;
    }
}