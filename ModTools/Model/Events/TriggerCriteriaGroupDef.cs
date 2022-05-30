using System.ComponentModel;
using System.Xml.Serialization;

namespace ModTools.Model.Events;

[Serializable]
public class TriggerCriteriaGroupDef
{
    [XmlElement, DefaultValue(TriggerCriteriaGroupOpType.AND)]
    public TriggerCriteriaGroupOpType Op { get; set; }
    
    [XmlElement(ElementName = "Criterion")]
    public List<TriggerCriterionDef>? Criterion { get; set; }
    
    [XmlElement(ElementName = "CriteriaGroup")]
    public List<TriggerCriteriaGroupDef>? CriteriaGroup { get; set; }
}