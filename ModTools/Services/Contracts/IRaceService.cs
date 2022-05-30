using ModTools.Model.Race;

namespace ModTools.Services.Contracts;

public interface IRaceService
{
    CitizenRaceList? LoadRaceList(string path);
    void SaveRace(SaveRaceObject saveObject);
    AnalyzeResult AnalyzeRaces(CitizenRaceList? raceList);

    public class SaveRaceObject
    {
        public bool IsReplaceMod;
        public string gamePlayFolderPath;
        public string modFolderPath;
        public CitizenRace race;
        public CitizenRaceList raceList;
        public IEnumerable<string> citizenPortraitPaths;
    }

    public class AnalyzeResult
    {
        public IEnumerable<string>? ApprovalTypes { get; set; }
        public IEnumerable<string>? ApprovalTags { get; set; }
        public SpecialValue? SpecialValue { get; set; }
        public IEnumerable<string>? TargetTypes { get; set; }
        public IEnumerable<string>? BonusTypes { get; set; }
        public IEnumerable<string>? EffectTypes { get; set; }
        public IEnumerable<string>? DefaultTraits { get; set; }
        public IEnumerable<string>? ConsumedTraits { get; set; }
    }
}