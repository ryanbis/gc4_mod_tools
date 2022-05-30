using System.Xml.Serialization;

namespace ModTools.Model.String;

[XmlRoot("StringTable")]
public class StringTable
{
    [XmlElement(ElementName="Label")]
    public string Label { get; set; }
    
    [XmlElement(ElementName="String")]
    public string String { get; set; }
}