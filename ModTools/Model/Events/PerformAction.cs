using System.Xml.Serialization;

namespace ModTools.Model.Events;

[Serializable]
public class PerformAction
{
    [XmlElement]
    public ActionType Action { get; set; }
    
    // decimal
    [XmlElement(ElementName = "ValueParam")]
    public List<string>? ValueParams { get; set; }
    
    [XmlElement(ElementName = "StringParam")]
    public List<string>? StringParams { get; set; }
}