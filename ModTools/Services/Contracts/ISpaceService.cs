using ModTools.Model.Space;
using ModTools.Model.String;

namespace ModTools.Services.Contracts;

public interface ISpaceService
{
    StarsAndPlanets? LoadStarSystemsAndPlanets(string path);

    AnalyzeResult AnalyzeStarSystemsAndPlanets(StarsAndPlanets starsAndPlanets);

    void SaveStarSystemList(SaveObject saveObject);
    
    public class SaveObject
    {
        public string gameplayFolderPath;
        public string? modFolderPath;
        public bool IsReplaceMod;
        public StarSystemList starSystemList;
        public StarList starList;
        public PlanetList planetList;
    }

    public class StarsAndPlanets
    {
        public StarSystemList StarSystemList { get; set; }
        public StarList StarList { get; set; }
        public PlanetList PlanetList { get; set; }
    }
    
    public class AnalyzeResult
    {
        // Star Systems
        public IEnumerable<string> LaneTypes { get; set; }
        public IEnumerable<string> BodyTypes { get; set; }
        public IEnumerable<string> BodyDefs { get; set; }
        
        // Planets
        public IEnumerable<string> PlanetTypes { get; set; }
        public IEnumerable<string> PlanetTraits { get; set; }
        public IEnumerable<string> PlanetArtDefines { get; set; }
        public IEnumerable<string> LayoutAtlases { get; set; }
        
        // Stars
        public IEnumerable<string> ObjectTypes { get; set; }
        public IEnumerable<string> Types { get; set; }
        public IEnumerable<string> StarArtDefines { get; set; }
        public IEnumerable<string> SFXDefines { get; set; }
    }
}