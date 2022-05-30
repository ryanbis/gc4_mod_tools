using System.Xml.Serialization;

namespace ModTools.Model.Space;

[XmlRoot(ElementName="Planet")]
[Serializable]
public class Planet : IInternalGameDisplayItem, IParsedNameForStringTables
{
    [XmlElement(ElementName="InternalName")]
    public string InternalName { get; set; }

    [XmlElement(ElementName="DisplayName")]
    public string DisplayName { get; set; }
    
    [XmlElement(ElementName="PlanetType")]
    public string PlanetType { get; set; }
    
    [XmlElement(ElementName="PlanetClass")]
    public string PlanetClass { get; set; }
    
    [XmlElement(ElementName="PlanetTrait")]
    public string PlanetTrait { get; set; }
    
    [XmlElement(ElementName = "SFXDefine")]
    public string? SFXDefine { get; set; } 
    
    [XmlElement(ElementName = "StrategicResource")]
    public string? StrategicResource { get; set; }
    
    [XmlElement(ElementName = "DisableColonizationEvent")]
    public string? DisableColonizationEvent { get; set; }
    
    [XmlElement(ElementName = "ColonizationEventOverride")]
    public string? ColonizationEventOverride { get; set; }
    
    [XmlElement(ElementName="ArtDefine")]
    public string ArtDefine { get; set; }
    
    [XmlElement(ElementName="LayoutAtlas")]
    public string? LayoutAtlas { get; set; }
    
    [XmlElement(ElementName="LayoutAtlasIndex")]
    public string? LayoutAtlasIndex { get; set; }

    [XmlElement(ElementName = "PlanetClassDistribution")]
    public PlanetClassDistribution PlanetClassDistribution { get; set; } = new();

    [XmlIgnore]
    public string Name_Parsed { get; set; }
    [XmlIgnore]
    public string Name_Desired { get; set; }
}