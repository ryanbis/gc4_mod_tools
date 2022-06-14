using System.ComponentModel;
using System.Xml.Serialization;
using ModTools.Model.Other;

namespace ModTools.Model.Events;

[Serializable]
public class TargetDef
{
    [XmlElement]
    public TargetType TargetType { get; set; }
    
    [XmlElement]
    public TriggerGroupTargetType? TriggerGroupTargetType { get; set; }
    
    // bool
    [XmlElement]
    public string? TriggerGroupTargetTypeSpecified { get; set; }
    
    // int
    [XmlElement, DefaultValue("-1")] 
    public string? TargetOrdinalConstraint { get; set; }
    
    [XmlElement]
    public TargetQualifierType? TargetQualifier { get; set; }
    
    [XmlElement]
    public ImprovementType? ImprovementType { get; set; }
    
    [XmlElement]
    public ShipHullType? ShipHullType { get; set; }
    
    [XmlElement]
    public ShipComponentType? ShipComponentType { get; set; }
    
    [XmlElement]
    public StrategicResourceType? StrategicResourceType { get; set; }
    
    [XmlElement]
    public TradeRouteModifierTargetType? TradeRouteType { get; set; }

    [XmlElement, DefaultValue(TargetRelationType.Self)] 
    public TargetRelationType? TargetRelation { get; set; }
    
    [XmlElement(ElementName = "StringParam")]
    public List<string>? StringParams { get; set; }
}