using ModTools.Model.Race;

namespace ModTools.View.Contracts;

public interface IColonyStatView : IOnSaveView<ColonyStats>
{
    DialogResult ShowAddColonyStatDialog(IEnumerable<string>? targetTypes, IEnumerable<string>? bonusTypes, IEnumerable<string>? effectTypes, OnSave saveDelegate);
    DialogResult ShowAddColonyStatDialog(IEnumerable<string>? targetTypes, IEnumerable<string>? bonusTypes, IEnumerable<string>? effectTypes, ColonyStats currentStat, OnSave saveDelegate);
}