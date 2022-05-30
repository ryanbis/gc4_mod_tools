using System.Xml.Serialization;

namespace ModTools.Model;

public interface IInternalGameItem
{
    [XmlElement(ElementName="InternalName")]
    public string InternalName { get; set; }
}