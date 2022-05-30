using System.Xml.Serialization;

namespace ModTools.Model.Space;

[Serializable, XmlRoot(ElementName = "OrbitLane")]
public class OrbitLane
{
    [XmlElement(ElementName = "LaneType")]
    public string LaneType { get; set; }
    
    [XmlElement(ElementName = "MinPlanets")]
    public string? MinPlanets { get; set; }
    
    [XmlElement(ElementName = "MaxPlanets")]
    public string? MaxPlanets { get; set; }
    
    [XmlElement(ElementName = "Body")]
    public List<OrbitBody>? Bodies { get; set; }

    
    
}