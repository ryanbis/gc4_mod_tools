using System.Xml.Serialization;

namespace ModTools.Model.Space;

[XmlRoot(ElementName="PlanetClassDistribution")]
[Serializable]
public class PlanetClassDistribution
{
    [XmlElement(ElementName = "Minerals")] 
    public string Minerals { get; set; } = "0";
    
    [XmlElement(ElementName = "Technology")]
    public string Technology { get; set; } = "0";
    
    [XmlElement(ElementName = "Wealth")]
    public string Wealth { get; set; } = "0";
    
    [XmlElement(ElementName = "Fertility")]
    public string Fertility { get; set; } = "0";
    
    [XmlElement(ElementName = "PlanetInfluence")]
    public string PlanetInfluence { get; set; } = "0";
}