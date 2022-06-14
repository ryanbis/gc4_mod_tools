using System.ComponentModel;
using System.Xml.Serialization;

namespace ModTools.Model.Events;

[Serializable]
public class Trigger
{
    [XmlElement]
    public OnEventType OnEvent { get; set; }
    
    [XmlElement]
    public string? Name { get; set; }
    
    [XmlElement(ElementName = "CriteriaCampaignID")]
    public List<string>? CriteriaCampaignID { get; set; }

    // bool
    [XmlElement, DefaultValue("false")]
    public string? CriteriaInternalNameOR { get; set; }
    
    [XmlElement(ElementName = "CriteriaInternalName")]
    public List<string>? CriteriaInternalName { get; set; }

    [XmlElement, DefaultValue("0")]
    public string? CriteriaTurnNum { get; set; }
    
    [XmlElement(ElementName = "StringParam")]
    public List<string>? StringParams { get; set; }
    
    // decimal
    [XmlElement(ElementName = "ValueParam")]
    public List<string>? ValueParams { get; set; }

    [XmlElement, DefaultValue(ScopeType.Local)]
    public ScopeType? Scope { get; set; }
    
    [XmlElement]
    public TargetDef? Target { get; set; }

    [XmlElement, DefaultValue(ModifierLifetimeType.Source)]
    public ModifierLifetimeType? Lifetime { get; set; }
    
    // int
    [XmlElement, DefaultValue("-1")]
    public string? Duration { get; set; }
    
    // int
    [XmlElement, DefaultValue("-1")]
    public string? RandomDurationMin { get; set; }
    
    // int
    [XmlElement, DefaultValue("-1")]
    public string? RandomDurationMax { get; set; }
    
    [XmlElement(ElementName = "Modifier")]
    public List<Modifier>? Modifiers { get; set; }
    
    [XmlElement(ElementName = "PerformAction")]
    public List<PerformAction>? PerformActions { get; set; }
    
    [XmlElement(ElementName = "Effect")]
    public List<TriggerTargetedEffectDef>? Effects { get; set; }
    
    [XmlElement(ElementName = "ConditionalEffect")]
    public List<TriggerConditionalEffectDef>? ConditionalEffects { get; set; }
    
    [XmlElement]
    public string? SourceDisplayName { get; set; }
    
    [XmlElement]
    public string? DescriptionText { get; set; }
}