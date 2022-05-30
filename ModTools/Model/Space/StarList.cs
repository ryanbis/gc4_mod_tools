using System.Xml.Serialization;

namespace ModTools.Model.Space;

public class StarList : IXmlModel
{
    [XmlAttribute(AttributeName = "noNamespaceSchemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
    public string NoNamespaceSchemaLocation { get; set; } = "../Schema/StarDefs.xsd";
    
    [XmlElement(ElementName = "Star")]
    public List<Star> Stars { get; set; }
}