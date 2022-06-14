using System.ComponentModel;
using System.Xml.Serialization;

namespace ModTools.Model.Events;

[Serializable, XmlRoot("GameEvent")]
public class GameEventDef : IParsedNameAndDescForStringTables
{
    [XmlElement]
    public string InternalName { get; set; }
    
    [XmlElement]
    public string DisplayName { get; set; }
    
    [XmlElement]
    public string? Description { get; set; }
    
    [XmlElement]
    public string? BonusDescription { get; set; }
    
    [XmlElement]
    public string? WindowTitle { get; set; }
    
    [XmlElement]
    public string? ArtDefine { get; set; }
    
    [XmlElement]
    public string? DisplayFaction { get; set; }
    
    [XmlElement]
    public string? ForegroundImage { get; set; }
    
    [XmlElement]
    public string? ForegroundBink { get; set; }
    
    [XmlElement]
    public string? BackgroundImage { get; set; }
    
    [XmlElement]
    public string? BackgroundBink { get; set; }
    
    // bool
    [XmlElement, DefaultValue("false")]
    public string? UseStaticEffect { get; set; }
    
    [XmlElement]
    public string? MusicDefine { get; set; }
    
    [XmlElement]
    public EventType Type { get; set; }
    
    // bool
    [XmlElement, DefaultValue("false")]
    public string? IsTutorial { get; set; }
    
    // bool
    [XmlElement, DefaultValue("false")]
    public string? TriggerForAllPlayers { get; set; }
    
    [XmlElement]
    public SpecialEventBehaviorType? Special { get; set; }
    
    [XmlElement]
    public string? SpecialContextFaction { get; set; }
    
    // bool
    [XmlElement, DefaultValue("false")]
    public string? ShouldInterruptOtherScreens { get; set; }
    
    // bool
    [XmlElement, DefaultValue("false")]
    public string? ShowImmediately { get; set; }
    
    // bool
    [XmlElement, DefaultValue("false")]
    public string? UseSidebar { get; set; }
    
    [XmlElement]
    public string? UseSavedEventTarget { get; set; }
    
    // bool
    [XmlElement, DefaultValue("false")]
    public string? CheckPlayerPrerequBeforeFiring { get; set; }

    // uint
    [XmlElement, DefaultValue("0")]
    public string? ForceWeight { get; set; }
    
    // uint
    [XmlElement]
    public string? Weight { get; set; }
    
    // uint
    [XmlElement, DefaultValue("0")]
    public string? Cooldown { get; set; }
    
    [XmlElement(ElementName = "Modifier")]
    public List<Modifier>? Modifiers { get; set; }
    
    [XmlElement(ElementName = "Trigger")]
    public List<Trigger>? Triggers { get; set; }
    
    [XmlElement(ElementName = "Choice")]
    public List<ChoiceDef>? Choices { get; set; }
    
    [XmlElement]
    public PrerequisiteDef? Prerequ { get; set; }
    
    [XmlElement]
    public PrerequisiteDef? Preclusions { get; set; }
    

    [XmlIgnore]
    public string Name_Parsed { get; set; }
    [XmlIgnore]
    public string Name_Desired { get; set; }
    [XmlIgnore]
    public string Description_Desired { get; set; }
}