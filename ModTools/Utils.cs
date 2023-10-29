using ModTools.View;
using System.Text;

namespace ModTools;

public static class Utils
{

    public static string GetModPath(params string[] pathSegments)
    {
        if (pathSegments.Length == 0)
        {
            return "";
        }
        var b = new StringBuilder();
        foreach (var path in pathSegments)
        {
            if (b.Length == 0)
            {
                b.Append(path).Append(Path.DirectorySeparatorChar).Append("Data");
            }
            else
            {
                b.Append(Path.DirectorySeparatorChar);
                b.Append(path);
            }
        }
        if (!b.ToString().EndsWith(Path.DirectorySeparatorChar))
        {
            b.Append(Path.DirectorySeparatorChar);
        }
        return b.ToString();
    }

    public static Color? getTextColorForModCrownComboBox(object sender, DrawItemEventArgs e, IEnumerable<string> list)
    {
        try
        {
            var combo = (ModCrownComboBox) sender;
            var target = combo.Items[e.Index].ToString();
            if (!list.Contains(target))
            {
                return Color.SlateGray;
            }
        }
        catch (Exception ex) {
        }

        return null;
    }
    
    public static object[] ProcessInGameList<T>(IEnumerable<string> gameList, out IEnumerable<string> sortedGameList, params string[] addedItems) where T : struct, Enum
    {
        var list = gameList.ToList();
        list.Sort();
        sortedGameList = list;
        list = Enum.GetNames<T>().ToList();
        list = list.Except(sortedGameList).ToList();
        if (addedItems != null && addedItems.Length > 0)
        {
            list.AddRange(addedItems);    
        }
        list.Sort();
        return sortedGameList.Concat(list).ToArray();
    }

    public static string GetToolsAppDataFolder()
    {
        var path = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}{Path.DirectorySeparatorChar}GC4ModTools{Path.DirectorySeparatorChar}";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        return path;
    }
}