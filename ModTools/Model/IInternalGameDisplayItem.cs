using System.Xml.Serialization;

namespace ModTools.Model;

public interface IInternalGameDisplayItem : IInternalGameItem
{
    [XmlElement(ElementName="DisplayName")]
    public string DisplayName { get; set; }
}