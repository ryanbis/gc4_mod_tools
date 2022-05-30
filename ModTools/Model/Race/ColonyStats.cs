using System.Xml.Serialization;

namespace ModTools.Model.Race;

[XmlRoot(ElementName="ColonyStats")]
[Serializable]
public class ColonyStats {
    [XmlElement(ElementName="EffectType")]
    public string EffectType { get; set; }
    [XmlElement(ElementName="Target")]
    public Target Target { get; set; }
    [XmlElement(ElementName="BonusType")]
    public string BonusType { get; set; }

    [XmlElement(ElementName = "Value")]
    public string Value { get; set; }
    [XmlElement(ElementName="ValueType")]
    public string ValueType { get; set; }
    [XmlElement(ElementName="SpecialValue")]
    public SpecialValue? SpecialValue { get; set; }

    public override int GetHashCode()
    {
        return HashCode.Combine(EffectType, Target, BonusType, ValueType);
    }

    public override string ToString()
    {
        return $"Target: {Target?.TargetType}  EffectType: {EffectType}  BonusType: {BonusType}  ValueType: {ValueType}  Value: {Value}  Special Value: {SpecialValue}";
    }
}