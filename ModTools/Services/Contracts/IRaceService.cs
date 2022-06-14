using ModTools.Model.Race;

namespace ModTools.Services.Contracts;

public interface IRaceService
{
    CitizenRaceList? LoadGameRaceList(string gamePlayFolderPath);
    CitizenRaceList? LoadRaceList(string path);
    void SaveRace(SaveRaceObject saveObject);
    GameUsedProperties GetGameUsedProperties();

    public class SaveRaceObject
    {
        public bool IsReplaceMod;
        public string gamePlayFolderPath;
        public string modFolderPath;
        public CitizenRace race;
        public CitizenRaceList raceList;
        public IEnumerable<string> citizenPortraitPaths;
    }

}