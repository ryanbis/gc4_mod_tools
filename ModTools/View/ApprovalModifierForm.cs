using ModTools.Model.Enum;
using ModTools.Model.Events;
using ModTools.Model.Race;
using ModTools.View.Contracts;
using ReaLTaiizor.Forms;

namespace ModTools.View;

public partial class ApprovalModifierForm : CrownForm, IApprovalModifierView
{
    
    private IEnumerable<string>? _gameUsedApprovalTypes;
    private string selectedType;
    private IEnumerable<string>? _gameUsedBonusTypes;
    private string selectedBonus;
    private IEnumerable<string>? _gameUsedTags;
    private string selectedTag;
    private string customTag;
    
    private IOnSaveView<ApprovalModifiers>.OnSave _saveDelegate;
    
    public ApprovalModifierForm()
    {
        InitializeComponent();
    }
    
    public DialogResult ShowAddApprovalModifierDialog(IEnumerable<string>? gameUsedApprovalTypes, IEnumerable<string>? gameUsedBonusTypes, IEnumerable<string>? gameUsedApprovalTags,
        IOnSaveView<ApprovalModifiers>.OnSave saveDelegate)
    {
        _gameUsedApprovalTypes = gameUsedApprovalTypes;
        _gameUsedBonusTypes = gameUsedBonusTypes;
        _gameUsedTags = gameUsedApprovalTags;
        _saveDelegate = saveDelegate;
        UpdateComboBoxes();
        bonusTypeComboBox.SelectedIndex = 0;
        UpdateCustomTagView();
        return ShowDialog();
    }

    public DialogResult ShowAddApprovalModifierDialog(IEnumerable<string>? gameUsedApprovalTypes, IEnumerable<string>? gameUsedBonusTypes, IEnumerable<string>? gameUsedApprovalTags,
        ApprovalModifiers currentMod, IOnSaveView<ApprovalModifiers>.OnSave saveDelegate)
    {
        _gameUsedApprovalTypes = gameUsedApprovalTypes;
        _gameUsedBonusTypes = gameUsedBonusTypes;
        _gameUsedTags = gameUsedApprovalTags;
        _saveDelegate = saveDelegate;
        UpdateComboBoxes();
        typeComboBox.SelectedItem = currentMod.Type;
        bonusTypeComboBox.SelectedItem = currentMod.BonusType;
        if (!string.IsNullOrWhiteSpace(currentMod.Tag))
        {
            tagComboBox.SelectedItem = currentMod.Tag;
            selectedTag = currentMod.Tag;
        }
        valueTextBox.Text = currentMod.Value;
        UpdateCustomTagView();
        return ShowDialog();
    }

    private void UpdateComboBoxes()
    {
        tagComboBox.Items.Clear();
        tagComboBox.Items.AddRange(_gameUsedTags.ToArray());
        if (!_gameUsedTags.Contains("Custom"))
        {
            tagComboBox.Items.Add("Custom");
        }

        var data = Utils.ProcessInGameList<ApprovalModifierType>(_gameUsedApprovalTypes, out _gameUsedApprovalTypes);
        typeComboBox.Items.Clear();
        typeComboBox.Items.AddRange(data);

        data = Utils.ProcessInGameList<ModifierBonusType>(_gameUsedBonusTypes, out _gameUsedBonusTypes);
        bonusTypeComboBox.Items.Clear();
        bonusTypeComboBox.Items.AddRange(data);
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        var isCustomTag = tagComboBox.SelectedItem.ToString() == "Custom";
        ApprovalModifiers mod = new()
        {
            Tag = isCustomTag ? customTag : selectedTag,
            Type = selectedType,
            BonusType = selectedBonus,
            Value = valueTextBox.Text
        };
        _saveDelegate?.Invoke(mod);
        Close();
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
        UpdateCustomTagView();
    }

    private void UpdateCustomTagView()
    {
        if (!string.IsNullOrWhiteSpace(selectedTag) && selectedTag.Equals("Custom"))
        {
            tableLayoutPanel1.RowStyles[3].SizeType = SizeType.AutoSize;
        }
        else
        {
            tableLayoutPanel1.RowStyles[3].SizeType = SizeType.Absolute;
            tableLayoutPanel1.RowStyles[3].Height = 0;
        }
    }

    private Color? approvalTypeDrawItem(object sender, DrawItemEventArgs e)
    {
        return Utils.getTextColorForModCrownComboBox(sender, e, _gameUsedApprovalTypes);
    }

    private Color? bonusTypeDrawItem(object sender, DrawItemEventArgs e)
    {
        return Utils.getTextColorForModCrownComboBox(sender, e, _gameUsedBonusTypes);
    }

    private Color? tagDrawItem(object sender, DrawItemEventArgs e)
    {
        return Utils.getTextColorForModCrownComboBox(sender, e, _gameUsedTags);
    }

    private void customTagTextChanged(object sender, EventArgs e)
    {
        customTag = customTagTextBox.Text;
    }
}