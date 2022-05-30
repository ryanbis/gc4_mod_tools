using System.Xml.Serialization;

namespace ModTools.Model.Space;

[Serializable, XmlRoot(ElementName = "StarSystem")]
public class StarSystem : IInternalGameDisplayItem, IParsedNameAndDescForStringTables
{
    [XmlElement(ElementName="InternalName")]
    public string InternalName { get; set; }
    
    [XmlElement(ElementName="DisplayName")]
    public string? DisplayName { get; set; }
    
    [XmlElement(ElementName="Description")]
    public string? Description { get; set; }
    
    [XmlElement(ElementName = "Weight")]
    public string? Weight { get; set; }

    [XmlElement(ElementName = "OrbitLane")]
    public List<OrbitLane>? OrbitLanes { get; set; } = new();

    [XmlIgnore]
    public string Name_Parsed { get; set; }
    [XmlIgnore]
    public string Name_Desired { get; set; }
    [XmlIgnore]
    public string Description_Desired { get; set; }

    public StarSystem Clone()
    {
        var newSystem = new StarSystem
        {
            Description = Description,
            Weight = Weight,
            DisplayName = DisplayName,
            Description_Desired = Description_Desired,
            InternalName = InternalName,
            Name_Desired = Name_Desired,
            Name_Parsed = Name_Parsed,
            OrbitLanes = new List<OrbitLane>(OrbitLanes)
        };
        
        return newSystem;
    }
}