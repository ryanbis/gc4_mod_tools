using System.ComponentModel;
using System.Xml.Serialization;

namespace ModTools.Model.Events;

[Serializable]
public class PrereqOptionGroupDef
{
    [XmlElement(ElementName = "Option")]
    public List<string>? Options { get; set; }
    
    [XmlElement]
    public string? DefaultChoice { get; set; }

    [XmlElement, DefaultValue("0")]
    public string? Min { get; set; }
}