using System.Xml.Serialization;

namespace ModTools.Model;

public interface IParsedNameAndDescForStringTables : IParsedNameForStringTables
{
    [XmlIgnore]
    public string Description_Parsed { get; set; }
}