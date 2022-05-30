using System.Xml.Serialization;

namespace ModTools.Model;

public interface IParsedNameAndDescForStringTables : IParsedNameForStringTables
{
    [XmlIgnore]
    public string Description_Desired { get; set; }
}