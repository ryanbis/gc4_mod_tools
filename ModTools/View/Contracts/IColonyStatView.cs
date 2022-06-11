using ModTools.Model.Race;

namespace ModTools.View.Contracts;

public interface IColonyStatView : IOnSaveView<ColonyStats>
{
    DialogResult ShowAddColonyStatDialog(IEnumerable<string>? gameUsedTargetTypes, IEnumerable<string>? gameUsedBonusTypes, IEnumerable<string>? gameUsedEffectTypes, OnSave saveDelegate);
    DialogResult ShowAddColonyStatDialog(IEnumerable<string>? gameUsedTargetTypes, IEnumerable<string>? gameUsedBonusTypes, IEnumerable<string>? gameUsedEffectTypes, ColonyStats currentStat, OnSave saveDelegate);
}