using ModTools.Model.Race;
using ModTools.View.Contracts;
using ReaLTaiizor.Forms;

namespace ModTools.View;

public partial class ColonyStatForm : CrownForm, IColonyStatView
{

    private IOnSaveView<ColonyStats>.OnSave _saveDelegate;
    private IEnumerable<string>? _targetTypes;
    private string selectedTarget;
    private IEnumerable<string>? _bonusTypes;
    private string selectedBonus;
    private IEnumerable<string>? _effectTypes;
    private string selectedEffect;
    private bool _hasSpecialValue;
    private SpecialValue? _specialValue;
    
    public ColonyStatForm()
    {
        InitializeComponent();
    }

    
    public DialogResult ShowAddColonyStatDialog(IEnumerable<string>? targetTypes, IEnumerable<string>? bonusTypes, IEnumerable<string>? effectTypes,
        SpecialValue? specialValue, IOnSaveView<ColonyStats>.OnSave saveDelegate)
    {
        _targetTypes = targetTypes;
        _bonusTypes = bonusTypes;
        _effectTypes = effectTypes;
        _specialValue = specialValue;
        _saveDelegate = saveDelegate;
        targetTypeComboBox.Items.Clear();
        targetTypeComboBox.Items.AddRange(_targetTypes.ToArray());
        bonusTypeComboBox.Items.Clear();
        bonusTypeComboBox.Items.AddRange(_bonusTypes.ToArray());
        effectTypeComboBox.Items.Clear();
        effectTypeComboBox.Items.AddRange(_effectTypes.ToArray());
        return ShowDialog();
    }

    public DialogResult ShowAddColonyStatDialog(IEnumerable<string>? targetTypes, IEnumerable<string>? bonusTypes, IEnumerable<string>? effectTypes,
        SpecialValue? specialValue, ColonyStats currentStat, IOnSaveView<ColonyStats>.OnSave saveDelegate)
    {
        _targetTypes = targetTypes;
        _bonusTypes = bonusTypes;
        _effectTypes = effectTypes;
        _specialValue = specialValue;
        _saveDelegate = saveDelegate;
        targetTypeComboBox.Items.Clear();
        targetTypeComboBox.Items.AddRange(_targetTypes.ToArray());
        bonusTypeComboBox.Items.Clear();
        bonusTypeComboBox.Items.AddRange(_bonusTypes.ToArray());
        effectTypeComboBox.Items.Clear();
        effectTypeComboBox.Items.AddRange(_effectTypes.ToArray());
        targetTypeComboBox.SelectedItem = currentStat.Target.TargetType;
        bonusTypeComboBox.SelectedItem = currentStat.BonusType;
        effectTypeComboBox.SelectedItem = currentStat.EffectType;
        valueTextBox.Text = currentStat.Value;
        specialValueCheckBox.Checked = currentStat.SpecialValue != null;
        return ShowDialog();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        ColonyStats stat = new()
        {
            Target = new Target { TargetType = selectedTarget },
            BonusType = selectedBonus,
            EffectType = selectedEffect,
            Value = valueTextBox.Text
        };
        if (specialValueCheckBox.Checked)
        {
            stat.ValueType = "Special";
            stat.SpecialValue = _specialValue;
        }
        _saveDelegate?.Invoke(stat);
        Hide();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Hide();
    }

    private void targetTypeSelected(object sender, EventArgs e)
    {
        selectedTarget = (sender as ComboBox).SelectedItem.ToString();
    }

    private void bonusTypeSelected(object sender, EventArgs e)
    {
        selectedBonus = (sender as ComboBox).SelectedItem.ToString();
    }

    private void effectTypeSelected(object sender, EventArgs e)
    {
        selectedEffect = (sender as ComboBox).SelectedItem.ToString();
    }

    
}