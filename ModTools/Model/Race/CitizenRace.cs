using System.Xml.Serialization;

namespace ModTools.Model.Race;

[XmlRoot(ElementName="CitizenRace")]
[Serializable]
public class CitizenRace : IInternalGameDisplayItem, IParsedNameAndDescForStringTables
{
    [XmlElement(ElementName="InternalName")]
    public string InternalName { get; set; }
    [XmlElement(ElementName="DisplayName")]
    public string DisplayName { get; set; }
    [XmlElement(ElementName="Description")]
    public string Description { get; set; }
    [XmlElement(ElementName = "IsMinorRace")]
    public bool IsMinorRace { get; set; }
    [XmlElement(ElementName="GenericImage")]
    public string GenericImage { get; set; }
    [XmlIgnore]
    public string GenericImageFullPath { get; set; }
    [XmlElement(ElementName="MilitaryAdvisorPortrait")]
    public string MilitaryAdvisorPortrait { get; set; }
    [XmlIgnore]
    public string MilitaryAdvisorPortraitFullPath { get; set; }
    [XmlElement(ElementName="ScienceAdvisorPortrait")]
    public string ScienceAdvisorPortrait { get; set; }
    [XmlIgnore]
    public string ScienceAdvisorPortraitFullPath { get; set; }
    [XmlElement(ElementName="ColonizationAdvisorPortrait")]
    public string ColonizationAdvisorPortrait { get; set; }
    [XmlIgnore]
    public string ColonizationAdvisorPortraitFullPath { get; set; }
    [XmlElement(ElementName="PoliticalAdvisorPortrait")]
    public string PoliticalAdvisorPortrait { get; set; }
    [XmlIgnore]
    public string PoliticalAdvisorPortraitFullPath { get; set; }

    [XmlElement(ElementName = "ProtestingApprovalThreshold")]
    public string? ProtestingApprovalThreshold { get; set; } = "0.25";

    [XmlElement(ElementName = "IdeologyChance")]
    public string? IdeologyChance { get; set; } = "0.2";

    [XmlElement(ElementName = "CriminalChance")]
    public string? CriminalChance { get; set; } = "0.1";

    [XmlElement(ElementName = "EmporiumChance")]
    public string? EmporiumChance { get; set; } = "0.1";

    [XmlElement(ElementName = "NaturalLeagueChance")]
    public string? NaturalLeagueChance { get; set; } = "0";

    [XmlElement(ElementName = "PacifistChance")]
    public string? PacifistChance { get; set; } = "0";

    [XmlElement(ElementName = "WarforgedChance")]
    public string? WarforgedChance { get; set; } = "0";
    [XmlElement(ElementName="GlobalStats")]
    public List<GlobalStats> GlobalStats { get; set; }
    [XmlElement(ElementName="ColonyStats")]
    public List<ColonyStats> ColonyStats { get; set; }
    [XmlElement(ElementName="ApprovalModifiers")]
    public List<ApprovalModifiers> ApprovalModifiers { get; set; }

    [XmlElement(ElementName = "HasGender")]
    public bool HasGender { get; set; }
    [XmlElement(ElementName="DefaultTraits")]
    public string DefaultTraits { get; set; }
    [XmlElement(ElementName = "ConsumedTrait")]
    public string ConsumedTrait { get; set; }
    [XmlIgnore]
    public string Name_Parsed { get; set; }
    [XmlIgnore]
    public string Name_Desired { get; set; }
    [XmlIgnore]
    public string Description_Desired { get; set; }
    [XmlIgnore]
    public bool IsDefaultRace { get; set; }
}