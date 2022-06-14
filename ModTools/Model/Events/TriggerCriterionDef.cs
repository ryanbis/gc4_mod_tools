using System.Xml.Serialization;

namespace ModTools.Model.Events;

[Serializable]
public class TriggerCriterionDef
{
    [XmlElement]
    public TargetDef Target { get; set; }
    
    [XmlElement]
    public PrerequisiteDef PrereqCheck { get; set; }
}