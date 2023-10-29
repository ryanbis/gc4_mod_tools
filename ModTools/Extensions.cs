using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using ModTools.Model.EffectType;
using ModTools.Model.Space;

namespace ModTools;

public static class Extensions
{
    public static T DeepCopy<T>(this T obj)
    {
        using var ms = new MemoryStream();
        var formatter = new BinaryFormatter();
        formatter.Serialize(ms, obj);
        ms.Seek(0, SeekOrigin.Begin);
        return (T) formatter.Deserialize(ms);
    }

    public static void SerializeToXml<T>(this T obj, string filePath)
    {
        var serializer = new XmlSerializer(typeof(T));
        var settings = new XmlWriterSettings {Indent = true};
        using var xmlWriter = XmlWriter.Create(filePath, settings);
        serializer.Serialize(xmlWriter, obj);
    }

    public static Bitmap LoadIconBitmap(this EffectType effectType)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var stream = assembly.GetManifestResourceStream(assembly.GetName().Name + ".Images." + effectType.IconFile);
        var bitmap = new Bitmap(stream);
        return bitmap;
    }
    
    public static string ToDescriptionString(this Enum val)
    {
        DescriptionAttribute[] attributes = (DescriptionAttribute[]) val
            .GetType()
            .GetField(val.ToString())
            .GetCustomAttributes(typeof(DescriptionAttribute), false);
        return attributes.Length > 0 ? attributes[0].Description : string.Empty;
    }

    public static int? VerifyInt(this TextBox textBox)
    {
        var text = textBox.Text;
        int? number = int.TryParse(text, out int val) ? val : null;

        textBox.Text = number?.ToString() ?? "";
        return number;
    }
    
    public static double? VerifyDouble(this TextBox textBox)
    {
        var text = textBox.Text;
        double? number = double.TryParse(text, out double val) ? val : null;

        textBox.Text = number?.ToString() ?? "";
        return number;
    }

    public static List<OrbitBody> GetPlanets(this StarSystem starSystem)
    {
        return starSystem.OrbitLanes.Where(l => l.LaneType != Constants.Space.STAR_SUFFIX).SelectMany(l => l.Bodies.Where(b => b.BodyDef == Constants.Space.PLANET_PREFIX)).ToList();
    }

    public static OrbitBody GetStar(this StarSystem starSystem)
    {
        return starSystem.OrbitLanes.Where(l => l.LaneType == Constants.Space.STAR_SUFFIX).First().Bodies[0];
    }
}