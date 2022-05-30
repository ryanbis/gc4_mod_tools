using ModTools.Model;

namespace ModTools.Services.Contracts;

public interface IGameFileCacheService
{
    T GetGameFile<T>(string filePath) where T : IXmlModel; 
}