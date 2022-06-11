using ModTools.View;

namespace ModTools;

public static class Utils
{
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
}