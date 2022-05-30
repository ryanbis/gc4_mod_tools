using System.Xml.Serialization;

namespace ModTools.Model;

public interface IParsedNameForStringTables
{
    [XmlIgnore]
    public string Name_Parsed { get; set; }
    [XmlIgnore]
    public string Name_Desired { get; set; }
}