using ModTools.Model.Race;

namespace ModTools.View.Contracts;

public interface IApprovalModifierView : IOnSaveView<ApprovalModifiers>
{
    DialogResult ShowAddApprovalModifierDialog(IEnumerable<string>? types, IEnumerable<string>? bonusTypes, IEnumerable<string>? tags, OnSave saveDelegate);
    DialogResult ShowAddApprovalModifierDialog(IEnumerable<string>? types, IEnumerable<string>? bonusTypes, IEnumerable<string>? tags, ApprovalModifiers currentMod, OnSave saveDelegate);
}