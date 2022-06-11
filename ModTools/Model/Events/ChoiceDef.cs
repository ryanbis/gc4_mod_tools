using System.Xml.Serialization;

namespace ModTools.Model.Events;

[Serializable]
public class ChoiceDef
{
    [XmlElement]
    public CulturalAlignmentType Type { get; set; }
    
    [XmlElement]
    public string? Description { get; set; }
    
    [XmlElement]
    public string? BonusDescription { get; set; }
    
    [XmlElement(ElementName = "Modifier")]
    public List<Modifier>? Modifiers { get; set; }
    
    [XmlElement(ElementName = "Trigger")]
    public List<Trigger>? Triggers { get; set; }
    
    [XmlElement]
    public PrerequisiteDef? Prerequ { get; set; }
    
    [XmlElement]
    public PrerequisiteDef? Preclusions { get; set; }
    
    // decimal
    [XmlElement]
    public string? AIDefaultWeight { get; set; }
}