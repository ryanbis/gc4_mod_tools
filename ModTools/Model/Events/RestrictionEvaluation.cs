using System.Xml.Serialization;

namespace ModTools.Model.Events;

[Serializable]
public class RestrictionEvaluation
{
    [XmlElement]
    public RestrictionType Type { get; set; }
    
    [XmlElement]
    public StatEvaluation? Evaluation { get; set; }
}