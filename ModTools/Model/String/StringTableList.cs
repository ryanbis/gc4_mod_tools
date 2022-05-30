using System.Xml.Serialization;

namespace ModTools.Model.String;

[Serializable, XmlRoot("StringTableList")]
public class StringTableList : IXmlModel
{
    [XmlElement(ElementName = "StringTable")]
    public List<StringTable> StringTables { get; set; } = new();

    [XmlAttribute(AttributeName = "noNamespaceSchemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
    public string NoNamespaceSchemaLocation { get; set; } = "../../Schema/Lib/StringTable.xsd";
}