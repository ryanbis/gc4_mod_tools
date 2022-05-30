using System.Xml.Serialization;

namespace ModTools.Model.Race;

[XmlRoot(ElementName="FlavorTextOption")]
[Serializable]
public class CitizenPortraitList
{
    [XmlElement(ElementName = "Requirements")]
    public Requirements Requirements { get; set; }
    
    [XmlElement(ElementName = "Text")]
    public List<string> Portraits { get; set; }
}