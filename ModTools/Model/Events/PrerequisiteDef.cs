using System.ComponentModel;
using System.Xml.Serialization;

namespace ModTools.Model.Events;

[Serializable]
public class PrerequisiteDef
{
    // bool
    [XmlElement, DefaultValue("false")]
    public string? Unavailable { get; set; }
    
    [XmlElement(ElementName = "Government")]
    public List<PrereqOptionGroupDef>? Governments { get; set; }
    
    [XmlElement(ElementName = "Techs")]
    public List<PrereqOptionGroupDef>? Techs { get; set; }
    
    [XmlElement(ElementName = "Culture")]
    public List<PrereqOptionGroupDef>? Cultures { get; set; }
    
    [XmlElement(ElementName = "Ideology")]
    public List<PrereqOptionGroupDef>? Ideologies { get; set; }
    
    [XmlElement(ElementName = "RaceTrait")]
    public List<PrereqOptionGroupDef>? RaceTraits { get; set; }
    
    [XmlElement(ElementName = "TechAge")]
    public List<PrereqOptionGroupDef>? TechAges { get; set; }
    
    [XmlArray]
    [XmlArrayItem("Option", typeof(PrereqValueOptionDef), IsNullable = false)]
    public List<List<PrereqValueOptionDef>>? Stat { get; set; }
    
    [XmlElement(ElementName = "Relation")]
    public List<PrereqOptionGroupDef>? Relations { get; set; }
    
    [XmlElement(ElementName = "CitizenRace")]
    public List<PrereqOptionGroupDef>? CitizenRaces { get; set; }
    
    [XmlElement(ElementName = "LeaderType")]
    public List<PrereqOptionGroupDef>? LeaderTypes { get; set; }
    
    [XmlElement(ElementName = "UnitTrait")]
    public List<PrereqOptionGroupDef>? UnitTraits { get; set; }
    
    [XmlElement(ElementName = "AssignedMinister")]
    public List<PrereqOptionGroupDef>? AssignedMinisters { get; set; }
    
    [XmlElement(ElementName = "PlanetTrait")]
    public List<PrereqOptionGroupDef>? PlanetTraits { get; set; }
    
    [XmlElement(ElementName = "PlanetHasImprovement")]
    public List<PrereqOptionGroupDef>? PlanetHasImprovements { get; set; }
    
    [XmlArray]
    [XmlArrayItem("Option", typeof(PrereqCounterOptionDef), IsNullable = false)]
    public List<List<PrereqCounterOptionDef>>? Counter { get; set; }
    
    [XmlElement(ElementName = "Improvement")]
    public List<string>? Improvements { get; set; }
    
    [XmlElement]
    public ImprovementType? ImprovementType { get; set; }
    
    [XmlElement(ElementName = "StarbaseModule")]
    public List<string>? StarbaseModules { get; set; }
    
    [XmlElement(ElementName = "ShipComponent")]
    public List<PrereqOptionGroupDef>? ShipComponents { get; set; }

    [XmlElement(ElementName = "ShipComponentType")]
    public List<PrereqOptionGroupDef>? ShipComponentsTypes { get; set; }
    
    [XmlElement]
    public string? UpgradesFrom { get; set; }
    
    // bool
    [XmlElement]
    public string? ColonySponsoringShipyard { get; set; }
    
    [XmlElement]
    public PlayerType? PlayerType { get; set; }
    
    [XmlElement]
    public string? MegaEvent { get; set; }
    
    // int
    [XmlElement, DefaultValue("0")]
    public string? Turns { get; set; }
    
    [XmlElement]
    public GalaxySizeType? GalaxySize { get; set; }
    
    // int
    [XmlElement, DefaultValue("0")]
    public string? NumPlayers { get; set; }
    
    // int
    [XmlElement, DefaultValue("0")]
    public string? NumAIPlayers { get; set; }
    
    // int
    [XmlElement, DefaultValue("0")]
    public string? NumHumanPlayers { get; set; }
    
    // int
    [XmlElement, DefaultValue("0")]
    public string? AllPlayersHaveNumColonies { get; set; }
    
    // int
    [XmlElement, DefaultValue("0")]
    public string? HasNumCoreColonies { get; set; }
    
    // int
    [XmlElement, DefaultValue("0")]
    public string? HasNumColonies { get; set; }
    
    [XmlElement]
    public PrereqConditionType? IsCoreWorld { get; set; }
    
    [XmlElement]
    public PrereqConditionType? IsCapital { get; set; }
    
    [XmlElement]
    public PrereqConditionType? CitizenRaceMatchesFaction { get; set; }
    
    [XmlElement]
    public PrereqConditionType? IsDamaged { get; set; }
    
    //decimal
    [XmlElement, DefaultValue("0")]
    public string? FactionPowerAbsolute { get; set; }

    //decimal
    [XmlElement, DefaultValue("0")]
    public string? FactionPowerMultipleFromAverage { get; set; }
    
    // int
    [XmlElement, DefaultValue("0")]
    public string? PeaceTurns { get; set; }
    
    // int
    [XmlElement, DefaultValue("0")]
    public string? WarTurns { get; set; }
    
    // int
    [XmlElement, DefaultValue("0")]
    public string? LatestTurn { get; set; }
    
    // int
    [XmlElement, DefaultValue("0")]
    public string? EarliestTurn { get; set; }
    
    // int
    [XmlElement, DefaultValue("0")]
    public string? MinNumFactionsAtWarWith { get; set; }
    
    // int
    [XmlElement, DefaultValue("0")]
    public string? MinNumFactionsAtPeaceWith { get; set; }
    
    // int
    [XmlElement, DefaultValue("0")]
    public string? MinNumFactionsInAllianceWith { get; set; }
    
    // int
    [XmlElement, DefaultValue("0")]
    public string? HasNumNonSovereignGovernors { get; set; }
    
    [XmlElement]
    public string? UPResolution { get; set; }
    
    [XmlElement]
    public string? EventChoice { get; set; }
    
    [XmlElement]
    public string? Flag { get; set; }
    
    [XmlElement]
    public FleetContainsObjectType? FleetContainsObjectType { get; set; }
    
    [XmlElement]
    public string? FleetContainsShipClass { get; set; }

    [XmlElement, DefaultValue(UnitGlobalType.Citizen)]
    public UnitGlobalType? UnitTypeForm { get; set; }
    
    // bool
    [XmlElement, DefaultValue("false")]
    public string? MustBeOnPlanet { get; set; }
    
    // bool
    [XmlElement, DefaultValue("false")]
    public string? AtColonyLimit { get; set; }
    
    // int
    [XmlElement, DefaultValue("0")]
    public string? UnderFactionApproval { get; set; }
    
    // int
    [XmlElement, DefaultValue("0")]
    public string? OverFactionApproval { get; set; }
    
    // bool
    [XmlElement, DefaultValue("false")]
    public string? NeedGovernmentTierUpgradeAvailable { get; set; }
    
    // bool
    [XmlElement, DefaultValue("false")]
    public string? NotSovereign { get; set; }
    
    // bool
    [XmlElement, DefaultValue("false")]
    public string? NotHomeworld { get; set; }
    
    // bool
    [XmlElement, DefaultValue("false")]
    public string? HasForeignInfluence { get; set; }
    
    [XmlElement(ElementName = "Tag")]
    public List<PrereqOptionGroupDef>? Tags { get; set; }
    
    // bool
    [XmlElement, DefaultValue("false")]
    public string? OccursOnce { get; set; }
    
    // bool
    [XmlElement, DefaultValue("false")]
    public string? OccursOncePerPlayer { get; set; }
    
    // bool
    [XmlElement, DefaultValue("false")]
    public string? OverrideOr { get; set; }
    
    [XmlElement]
    public string? DLC { get; set; }
}