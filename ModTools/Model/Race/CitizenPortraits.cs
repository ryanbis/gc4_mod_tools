using System.Xml.Serialization;

namespace ModTools.Model.Race;

[Serializable, XmlRoot("FlavorTextDef")]
public class CitizenPortraits
{
    [XmlElement(ElementName = "InternalName")]
    public string InternalName { get; set; } = "PORTRAIT";
    
    [XmlElement(ElementName = "FlavorTextOption")]
    public List<CitizenPortraitList> CitizenPortraitLists { get; set; }
}