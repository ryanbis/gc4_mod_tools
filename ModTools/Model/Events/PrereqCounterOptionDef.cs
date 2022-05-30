using System.ComponentModel;
using System.Xml.Serialization;

namespace ModTools.Model.Events;

[Serializable]
public class PrereqCounterOptionDef
{
    [XmlElement]
    public string CounterName { get; set; }
    
    [XmlElement]
    public EvaluationType? Condition { get; set; }
    
    // decimal
    [XmlElement, DefaultValue("0")]
    public string? Threshold { get; set; }
}