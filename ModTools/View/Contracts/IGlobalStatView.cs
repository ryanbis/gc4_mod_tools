using ModTools.Model.Race;

namespace ModTools.View.Contracts;

public interface IGlobalStatView : IOnSaveView<GlobalStats>
{
    DialogResult ShowAddGlobalStatDialog(IEnumerable<string>? gameUsedTargetTypes, IEnumerable<string>? gameUsedBonusTypes, IEnumerable<string>? gameUsedEffectTypes, OnSave saveDelegate);
    DialogResult ShowAddGlobalStatDialog(IEnumerable<string>? gameUsedTargetTypes, IEnumerable<string>? gameUsedBonusTypes, IEnumerable<string>? gameUsedEffectTypes, GlobalStats currentStat, OnSave saveDelegate);
}