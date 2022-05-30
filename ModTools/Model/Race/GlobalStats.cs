using System.Xml.Serialization;

namespace ModTools.Model.Race;

[XmlRoot(ElementName="GlobalStats")]
[Serializable]
public class GlobalStats {
    [XmlElement(ElementName="EffectType")]
    public string EffectType { get; set; }
    [XmlElement(ElementName="Target")]
    public Target Target { get; set; }
    [XmlElement(ElementName="BonusType")]
    public string BonusType { get; set; }
    [XmlElement(ElementName="Value")]
    public string Value { get; set; }
    
    public override int GetHashCode()
    {
        return HashCode.Combine(EffectType, Target, BonusType);
    }

    public override string ToString()
    {
        return $"Target: {Target?.TargetType}  BonusType: {BonusType}  EffectType: {EffectType}  Value: {Value}";
    }
}