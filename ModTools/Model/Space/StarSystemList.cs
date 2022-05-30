using System.Xml.Serialization;

namespace ModTools.Model.Space;

[Serializable, XmlRoot("StarSystemList")]
public class StarSystemList : IXmlModel
{
    [XmlAttribute(AttributeName = "noNamespaceSchemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
    public string NoNamespaceSchemaLocation { get; set; } = "../Schema/StarSystemDefs.xsd";
    
    [XmlElement(ElementName = "StarSystemGroup")]
    public List<StarSystemGroup> StarSystemGroups { get; set; }
    
    [XmlIgnore]
    public string BasePath { get; set; }
}