using System.Xml.Serialization;

namespace ModTools.Model.Events;
[Serializable, XmlRoot(ElementName = "GameEventList")]
public class GameEventList : IXmlModel
{
    [XmlAttribute(AttributeName = "noNamespaceSchemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
    public string NoNamespaceSchemaLocation { get; set; } = "../Schema/GameEventDefs.xsd";

    [XmlElement(ElementName = "GameEvent")]
    public List<GameEventDef> GameEvents { get; set; } = new();
}