using System.Xml.Serialization;

namespace ModTools.Model.Race;

[Serializable, XmlRoot("FlavorTextDefs")]
public class CitizenPortraitsFlavorTextDefs : IXmlModel
{
    [XmlAttribute(AttributeName = "noNamespaceSchemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
    public string NoNamespaceSchemaLocation { get; set; } = "../../Schema/FlavorText.xsd";

    [XmlElement(ElementName = "FlavorTextDef")]
    public CitizenPortraits CitizenPortraits { get; set; }
    
}