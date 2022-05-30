using System.Xml.Serialization;

namespace ModTools.Model.Space;

[Serializable, XmlRoot("PlanetList")]
public class PlanetList : IXmlModel
{
    [XmlAttribute(AttributeName = "noNamespaceSchemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
    public string NoNamespaceSchemaLocation { get; set; } = "../Schema/PlanetDefs.xsd";
    
    [XmlElement(ElementName = "Planet")]
    public List<Planet> Planets { get; set; }
}