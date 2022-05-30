using System.Xml.Serialization;

namespace ModTools.Model.Events;

[Serializable]
public class StatEvaluation
{
    [XmlElement]
    public StatType Stat { get; set; }
    
    [XmlElement]
    public EvaluationType Condition { get; set; }
    
    [XmlElement]
    public string? Threshold { get; set; }
}