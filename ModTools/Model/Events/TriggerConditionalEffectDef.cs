using System.Xml.Serialization;

namespace ModTools.Model.Events;

[Serializable]
public class TriggerConditionalEffectDef
{
    [XmlElement]
    public TriggerCriteriaGroupDef If { get; set; }
    
    [XmlElement(ElementName = "IfEffect")]
    public List<TriggerTargetedEffectDef>? IfEffects { get; set; }
    
    [XmlElement(ElementName = "IfConditionalEffect")]
    public List<TriggerConditionalEffectDef>? IfConditionalEffects { get; set; }
    
    [XmlElement(ElementName = "ElseEffect")]
    public List<TriggerTargetedEffectDef>? ElseEffects { get; set; }
    
    [XmlElement(ElementName = "ElseConditionalEffect")]
    public List<TriggerConditionalEffectDef>? ElseConditionalEffects { get; set; }
}