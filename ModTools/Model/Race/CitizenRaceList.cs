using System.Xml.Serialization;

namespace ModTools.Model.Race;

[Serializable, XmlRoot("CitizenRaceList")]
public class CitizenRaceList : IXmlModel
{
    [XmlElement(ElementName = "CitizenRace")]
    public List<CitizenRace> CitizenRaces { get; set; } = new();

    // [XmlAttribute(AttributeName = "noNamespaceSchemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
    // public string NoNamespaceSchemaLocation { get; set; } = "../Schema/CitizenRaceDefs.xsd";

    [XmlIgnore]
    public string BasePath { get; set; }

    [XmlAttribute(AttributeName = "noNamespaceSchemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
    public string NoNamespaceSchemaLocation { get; set; } = "../Schema/CitizenRaceDefs.xsd";
}