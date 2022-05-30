using System.Xml.Serialization;

namespace ModTools.Model.Space;

[Serializable, XmlRoot(ElementName = "StarSystemGroup")]
public class StarSystemGroup : IInternalGameItem
{
    [XmlElement(ElementName="InternalName")]
    public string InternalName { get; set; }
    
    [XmlElement(ElementName = "StarSystem")]
    public List<StarSystem> StarSystems { get; set; }
}