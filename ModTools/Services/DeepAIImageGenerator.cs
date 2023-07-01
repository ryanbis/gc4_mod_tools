using DeepAI;
using ModTools.Services.Contracts;

namespace ModTools.Services;

public class DeepAIImageGenerator : IAIImageGenerator
{
    
    private DeepAI_API Api { get; set; }


    public void init(string apiKey)
    {
        Api = new DeepAI_API(apiKey);
    }

    public void generateImage(string text)
    {
        StandardApiResponse response = Api.callStandardApi("text2img", new {text});
        Console.Write(Api.objectAsJsonString(response));
    }
}