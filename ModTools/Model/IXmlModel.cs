using System.Xml.Serialization;

namespace ModTools.Model;

/// <summary>
/// Interface for xml models which are "top level" entries 
/// </summary>
public interface IXmlModel
{
    [XmlAttribute(AttributeName = "noNamespaceSchemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
    public string NoNamespaceSchemaLocation { get; set; }
}