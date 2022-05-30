using ModTools.Model.Race;

namespace ModTools.View.Contracts;

public interface IColonyStatView : IOnSaveView<ColonyStats>
{
    DialogResult ShowAddColonyStatDialog(IEnumerable<string>? targetTypes, IEnumerable<string>? bonusTypes, IEnumerable<string>? effectTypes, SpecialValue? specialValue, OnSave saveDelegate);
    DialogResult ShowAddColonyStatDialog(IEnumerable<string>? targetTypes, IEnumerable<string>? bonusTypes, IEnumerable<string>? effectTypes, SpecialValue? specialValue, ColonyStats currentStat, OnSave saveDelegate);
}