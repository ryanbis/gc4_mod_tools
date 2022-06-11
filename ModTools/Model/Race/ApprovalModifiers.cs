using System.Xml.Serialization;

namespace ModTools.Model.Race;

[XmlRoot(ElementName="ApprovalModifiers")]
[Serializable]
public class ApprovalModifiers {
    [XmlElement(ElementName="Type")]
    public string Type { get; set; }
    [XmlElement(ElementName="Value")]
    public string Value { get; set; }
    [XmlElement(ElementName="BonusType")]
    public string BonusType { get; set; }
    [XmlElement(ElementName="Tag")]
    public string? Tag { get; set; }
    
    public override int GetHashCode()
    {
        return HashCode.Combine(Type, BonusType, Tag);
    }

    public override string ToString()
    {
        return $"Type: {Type}  BonusType: {BonusType}  Tag: {Tag}  Value: {Value}";
    }
}