using ModTools.Model.Race;

namespace ModTools.View.Contracts;

public interface IApprovalModifierView : IOnSaveView<ApprovalModifiers>
{
    DialogResult ShowAddApprovalModifierDialog(IEnumerable<string>? gameUsedApprovalTypes, IEnumerable<string>? gameUsedBonusTypes, IEnumerable<string>? gameUsedApprovalTags, OnSave saveDelegate);
    DialogResult ShowAddApprovalModifierDialog(IEnumerable<string>? gameUsedApprovalTypes, IEnumerable<string>? gameUsedBonusTypes, IEnumerable<string>? gameUsedApprovalTags, ApprovalModifiers currentMod, OnSave saveDelegate);
}