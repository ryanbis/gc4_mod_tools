using System.ComponentModel;
using System.Xml.Serialization;

namespace ModTools.Model.Events;

[Serializable]
public class PrereqValueOptionDef
{
    [XmlElement]
    public string Name { get; set; }
    
    [XmlElement]
    public EvaluationType? Condition { get; set; }
    
    // decimal
    [XmlElement, DefaultValue("0")]
    public string? Threshold { get; set; }
    
    // decimal
    [XmlElement, DefaultValue("0")]
    public string? ThresholdUpper { get; set; }
}