using ModTools.Model.Race;

namespace ModTools.View.Contracts;

public interface IGlobalStatView : IOnSaveView<GlobalStats>
{
    DialogResult ShowAddGlobalStatDialog(IEnumerable<string>? targetTypes, IEnumerable<string>? bonusTypes, IEnumerable<string>? effectTypes, OnSave saveDelegate);
    DialogResult ShowAddGlobalStatDialog(IEnumerable<string>? targetTypes, IEnumerable<string>? bonusTypes, IEnumerable<string>? effectTypes, GlobalStats currentStat, OnSave saveDelegate);
}