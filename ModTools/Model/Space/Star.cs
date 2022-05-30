using System.Xml.Serialization;

namespace ModTools.Model.Space;

public class Star : IInternalGameDisplayItem, IParsedNameForStringTables
{
    [XmlElement(ElementName="InternalName")]
    public string InternalName { get; set; }
    
    [XmlElement(ElementName="DisplayName")]
    public string? DisplayName { get; set; }
    
    [XmlElement(ElementName="ObjectType")]
    public string ObjectType { get; set; }
    
    [XmlElement(ElementName="Type")]
    public string Type { get; set; }
    
    [XmlElement(ElementName="TypeDisplayName")]
    public string TypeDisplayName { get; set; }
    
    [XmlElement(ElementName = "AreaEffectDisplayName")]
    public string? AreaEffectDisplayName { get; set; }
    
    [XmlElement(ElementName="ArtDefine")]
    public string ArtDefine { get; set; }
    
    [XmlElement(ElementName="SFXDefine")]
    public string? SFXDefine { get; set; }

    [XmlIgnore]
    public string? Name_Parsed { get; set; }
    [XmlIgnore]
    public string? Name_Desired { get; set; }
    [XmlIgnore]
    public string? TypeDisplayName_Parsed { get; set; }
}