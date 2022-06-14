using System.ComponentModel;
using System.Xml.Serialization;

namespace ModTools.Model.Events;

[Serializable]
public class TriggerTargetedEffectDef
{
    [XmlElement(ElementName = "StringParam")]
    public List<string>? StringParams { get; set; }
    
    [XmlElement(ElementName = "ValueParam")]
    public List<string>? ValueParams { get; set; }
    
    [XmlElement]
    public TargetDef Target { get; set; }

    [XmlElement, DefaultValue(ModifierLifetimeType.Source)]
    public ModifierLifetimeType? Lifetime { get; set; }

    [XmlElement, DefaultValue("-1")]
    public string? Duration { get; set; }
    
    [XmlElement, DefaultValue("-1")]
    public string? RandomDurationMin { get; set; }

    [XmlElement, DefaultValue("-1")]
    public string? RandomDurationMax { get; set; }
    
    [XmlElement(ElementName = "Modifier")]
    public List<Modifier>? Modifiers { get; set; }
    
    [XmlElement(ElementName = "PerformAction")]
    public List<PerformAction>? PerformActions { get; set; }
}