using ModTools.Model.Race;
using ModTools.View.Contracts;
using ReaLTaiizor.Forms;

namespace ModTools.View;

public partial class ApprovalModifierForm : CrownForm, IApprovalModifierView
{
    
    private IEnumerable<string>? _types;
    private string selectedType;
    private IEnumerable<string>? _bonusTypes;
    private string selectedBonus;
    private IEnumerable<string>? _tags;
    private string selectedTag;
    
    private IOnSaveView<ApprovalModifiers>.OnSave _saveDelegate;
    
    public ApprovalModifierForm()
    {
        InitializeComponent();
    }
    
    public DialogResult ShowAddApprovalModifierDialog(IEnumerable<string>? types, IEnumerable<string>? bonusTypes, IEnumerable<string>? tags,
        IOnSaveView<ApprovalModifiers>.OnSave saveDelegate)
    {
        _types = types;
        _bonusTypes = bonusTypes;
        _tags = tags;
        _saveDelegate = saveDelegate;
        typeComboBox.Items.AddRange(_types.ToArray());
        bonusTypeComboBox.Items.AddRange(_bonusTypes.ToArray());
        tagComboBox.Items.AddRange(_tags.ToArray());
        return ShowDialog();
    }

    public DialogResult ShowAddApprovalModifierDialog(IEnumerable<string>? types, IEnumerable<string>? bonusTypes, IEnumerable<string>? tags,
        ApprovalModifiers currentMod, IOnSaveView<ApprovalModifiers>.OnSave saveDelegate)
    {
        _types = types;
        _bonusTypes = bonusTypes;
        _tags = tags;
        _saveDelegate = saveDelegate;
        typeComboBox.Items.AddRange(_types.ToArray());
        bonusTypeComboBox.Items.AddRange(_bonusTypes.ToArray());
        tagComboBox.Items.AddRange(_tags.ToArray());
        typeComboBox.SelectedItem = currentMod.Type;
        bonusTypeComboBox.SelectedItem = currentMod.BonusType;
        if (!string.IsNullOrWhiteSpace(currentMod.Tag))
        {
            tagComboBox.SelectedItem = currentMod.Tag;
        }
        valueTextBox.Text = currentMod.Value;
        return ShowDialog();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        ApprovalModifiers mod = new()
        {
            Tag = selectedTag,
            Type = selectedType,
            BonusType = selectedBonus,
            Value = valueTextBox.Text
        };
        _saveDelegate?.Invoke(mod);
        Hide();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Hide();
    }

    private void typeSelected(object sender, EventArgs e)
    {
        selectedType = (sender as ComboBox).SelectedItem.ToString();
    }

    private void bonusTypeSelected(object sender, EventArgs e)
    {
        selectedBonus = (sender as ComboBox).SelectedItem.ToString();
    }

    private void tagSelected(object sender, EventArgs e)
    {
        selectedTag = (sender as ComboBox).SelectedItem.ToString();
    }
    
}