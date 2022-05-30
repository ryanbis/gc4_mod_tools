using System.Xml.Serialization;

namespace ModTools.Model.Race;

[XmlRoot(ElementName="SpecialValue")]
[Serializable]
public class SpecialValue {
    [XmlElement(ElementName="Special")]
    public string Special { get; set; }
    [XmlElement(ElementName="ValueParam")]
    public List<string> ValueParam { get; set; }
    [XmlElement(ElementName="StringParam")]
    public string StringParam { get; set; }
    
    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = Special.GetHashCode();
            foreach (var val in ValueParam)
            {
                hashCode = (hashCode * 397) ^ val.GetHashCode();
            }
            hashCode = (hashCode * 397) ^ StringParam.GetHashCode();
            return hashCode;
        }
    }

    protected bool Equals(SpecialValue other)
    {
        return Special == other.Special && ValueParam.SequenceEqual(other.ValueParam) && StringParam == other.StringParam;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((SpecialValue) obj);
    }

    public static bool operator ==(SpecialValue? left, SpecialValue? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(SpecialValue? left, SpecialValue? right)
    {
        return !Equals(left, right);
    }
}