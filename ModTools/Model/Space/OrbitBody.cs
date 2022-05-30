using System.Xml.Serialization;

namespace ModTools.Model.Space;

[Serializable, XmlRoot(ElementName = "Body")]
public class OrbitBody
{
    [XmlElement(ElementName = "BodyType")]
    public string BodyType { get; set; }
    
    [XmlElement(ElementName = "BodyDef")]
    public string? BodyDef { get; set; }
    
    [XmlElement(ElementName = "IsHomeworld")]
    public string? IsHomeworld { get; set; }

    [XmlElement(ElementName = "Position")]
    public string? Position { get; set; }
    
    [XmlElement(ElementName = "MinCount")]
    public string? MinCount { get; set; }
    
    [XmlElement(ElementName = "MaxCount")]
    public string? MaxCount { get; set; }
    
    // The below never seems to be used, though it is listed in the schema xsd for OrbitBody
    // [XmlElement(ElementName = "AsteroidMineableChanceMod")]
    // public decimal? AsteroidMineableChanceMod { get; set; }
}