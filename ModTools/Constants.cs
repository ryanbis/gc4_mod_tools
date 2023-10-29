
namespace ModTools;

public static class Constants
{
    public const string DESCRIPTION_SUFFIX = "_Dec";
    public const string DISPLAYNAME_SUFFIX = "_Name";
    
    public static readonly string GAMEPLAY_PATH = $"Data{Path.DirectorySeparatorChar}Gameplay{Path.DirectorySeparatorChar}";
    public static readonly string RELATIVE_FROM_GAMEPLAY_TEXT_FOLDER = ".." + Path.DirectorySeparatorChar + "English" + 
                                                                       Path.DirectorySeparatorChar + "Text" + 
                                                                       Path.DirectorySeparatorChar;

    public static readonly string GFX_PATH = "Gfx";

    public static readonly string MAIN_MENU_BACKGROUND_PATH = $"{GFX_PATH}{Path.DirectorySeparatorChar}Mission4Image.png";
    public static readonly string GCIV_LOGO_PATH = $"{GFX_PATH}{Path.DirectorySeparatorChar}GC4_Supernova_Logo_S.png";


    public static class Race
    {
        public const string PREFIX = "Race_";

        // Installed file names
        public const string RACES_INSTALLED_FILENAME = "UnitRaceDefs.xml";
        public const string RACES_TEXT_INSTALLED_FILENAME = "UnitRaceText.xml";


        // TODO - To support multi-language in the future, this should be refactored out (perhaps have the user select
        // TODO - the text folder)

        public static readonly string RACE_CITIZEN_IMAGE_FOLDER = ".." + Path.DirectorySeparatorChar + ".." +
                                                                  Path.DirectorySeparatorChar + "Gfx" + Path.DirectorySeparatorChar + "Citizens" +
                                                                  Path.DirectorySeparatorChar + "{0}" + Path.DirectorySeparatorChar;

        public static readonly string CUSTOM_CITIZEN_DEFAULT_PATH = ".." + Path.DirectorySeparatorChar + ".." +
                                                                    Path.DirectorySeparatorChar + "Gfx" +
                                                                    Path.DirectorySeparatorChar + "Factions" +
                                                                    Path.DirectorySeparatorChar + "Portraits" +
                                                                    Path.DirectorySeparatorChar + "Custom.png";
    }

    public static class Space
    {
        public const string STAR_SYSTEM_SUFFIX = "System";
        public const string STAR_SUFFIX = "Star";
        public const string PLANET_PREFIX = "Planet";
        public const string STAR_SYSTEM_INSTALLED_FILENAME = "StarSystemDefs.xml";
        public const string PLANET_TEXT_INSTALLED_FILENAME = "PlanetText.xml";
        public const string STAR_TEXT_INSTALLED_FILENAME = "StarNamesText.xml";
        public const string STAR_SYSTEM_TEXT_INSTALLED_FILENAME = "StarSystemText.xml";
        public const string ALLIANCE_ASCENDANT_TEXT_FILENAME = "AllianceAscendantText.xml";
        public const string THE_OPPORTUNITY_TEXT_FILENAME = "TheOpportunityText.xml";
        public const string PLANET_DEFS_INSTALLED_FILENAME = "PlanetDefs.xml";
        public const string STAR_DEFS_INSTALLED_FILENAME = "StarDefs.xml";
        public const string STELLAR_OBJECT_TEXT_FILENAME = "StellarObjectText.xml";
        public const string GAME_TERM_TEXT_FILENAME = "GameTermText.xml";

        public const string FACTION_START_STAR_SYSTEMS = "FactionStart";
        public const string SYSTEM_TEMPLATE_STAR_GROUP = "SystemTemplate";

        public const string FACTION_START_KEY = "Civilization Starting Star System";
        public const string SYSTEM_TEMPLATE_KEY = "General Star System";

        public const string ASTEROID_BODY_DEF = "NormalAsteroid";

        public static readonly Dictionary<string, string> STAR_SYSTEM_GROUP_TYPES = new()
            {
                { FACTION_START_KEY, FACTION_START_STAR_SYSTEMS },
                { SYSTEM_TEMPLATE_KEY, SYSTEM_TEMPLATE_STAR_GROUP }
            };
    }

}