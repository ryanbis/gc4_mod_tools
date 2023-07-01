namespace ModTools.Services.Contracts;

public interface IAIImageGenerator
{
    void init(string apiKey);
    void generateImage(string text);
}