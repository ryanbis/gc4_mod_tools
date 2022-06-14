using System.Xml.Serialization;
using ModTools.Model.Events;
using ModTools.Model.Race;
using ValueType = ModTools.Model.Events.ValueType;

namespace ModTools.Model.Global;

[Serializable]
public class Modifier
{
    [XmlElement]
    public StatType EffectType { get; set; }

    [XmlElement]
    public ScopeType? Scope { get; set; }
    
    [XmlElement]
    public TargetDef? Target { get; set; }
    
    [XmlElement]
    public ModifierBonusType BonusType { get; set; }
    
    [XmlElement]
    public ValueType? ValueType { get; set; }
    
    [XmlElement(ElementName = "BestOf")]
    public List<ValueType>? BestOf { get; set; }
    
    // decimal
    [XmlElement]
    public string? Value { get; set; }
    
    //decimal
    [XmlElement]
    public string? RangeMin { get; set; }
    
    //decimal
    [XmlElement]
    public string? RangeMax { get; set; }
    
    [XmlElement]
    public SpecialValue? SpecialValue { get; set; }
    
    [XmlElement(ElementName = "Restrictions")]
    public List<RestrictionEvaluation>? Restrictions { get; set; }
}