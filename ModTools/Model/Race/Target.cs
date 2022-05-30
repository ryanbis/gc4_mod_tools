using System.Xml.Serialization;

namespace ModTools.Model.Race;

[XmlRoot(ElementName="Target")]
[Serializable]
public class Target {
    [XmlElement(ElementName="TargetType")]
    public string TargetType { get; set; }
    
}