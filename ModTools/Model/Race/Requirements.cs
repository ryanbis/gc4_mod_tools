using System.Xml.Serialization;

namespace ModTools.Model.Race;

[XmlRoot(ElementName="Requirements")]
[Serializable]
public class Requirements
{
    [XmlElement(ElementName = "CitizenRace")]
    public string CitizenRace { get; set; }
}