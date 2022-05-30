using System.ComponentModel;
using System.Xml.Serialization;

namespace ModTools.Model.Events;

[Serializable]
public class Modifier
{
    [XmlElement]
    public StatType EffectType { get; set; }

    [XmlElement, DefaultValue(ScopeType.Local)]
    public ScopeType Scope { get; set; }
    
    [XmlElement]
    public TargetDef Target { get; set; }
    
    [XmlElement]
    public ModifierBonusType BonusType { get; set; }

    [XmlElement, DefaultValue(Events.ValueType.Value)]
    public ValueType? ValueType { get; set; }
    
    [XmlElement(ElementName = "BestOf")]
    public List<ValueType>? BestOf { get; set; }
    
    // decimal
    [XmlElement]
    public string? Value { get; set; }
    
    // decimal
    [XmlElement]
    public string? RangeMin { get; set; }
    
    // decimal
    [XmlElement]
    public string? RangeMax { get; set; }
    
    [XmlElement]
    public SpecialValueType? SpecialValue { get; set; }
    
    [XmlElement(ElementName = "Restrictions")]
    public List<RestrictionEvaluation>? Restrictions { get; set; }
}