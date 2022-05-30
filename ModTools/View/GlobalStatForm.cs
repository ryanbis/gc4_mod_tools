using ModTools.Model.Race;
using ModTools.View.Contracts;
using ReaLTaiizor.Forms;

namespace ModTools.View;

public partial class GlobalStatForm : CrownForm, IGlobalStatView
{
    private IEnumerable<string>? _targetTypes;
    private string _selectedTarget;
    private IEnumerable<string>? _bonusTypes;
    private string _selectedBonus;
    private IEnumerable<string>? _effectTypes;
    private string _selectedEffect;
    private IGlobalStatView.OnSave _saveDelegate;


    public GlobalStatForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        GlobalStats stat = new()
        {
            Target = new Target { TargetType = _selectedTarget },
            BonusType = _selectedBonus,
            EffectType = _selectedEffect,
            Value = valueTextBox.Text
        };
        _saveDelegate?.Invoke(stat);
        Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void targetTypeSelected(object sender, EventArgs e)
    {
        _selectedTarget = (sender as ComboBox).SelectedItem.ToString();
    }

    private void bonusTypeSelected(object sender, EventArgs e)
    {
        _selectedBonus = (sender as ComboBox).SelectedItem.ToString();
    }

    private void effectTypeSelected(object sender, EventArgs e)
    {
        _selectedEffect = (sender as ComboBox).SelectedItem.ToString();
    }

    public DialogResult ShowAddGlobalStatDialog(IEnumerable<string>? targetTypes, IEnumerable<string>? bonusTypes, IEnumerable<string>? effectTypes,
        GlobalStats currentStat, IOnSaveView<GlobalStats>.OnSave saveDelegate)
    {
        _targetTypes = targetTypes;
        _bonusTypes = bonusTypes;
        _effectTypes = effectTypes;
        _saveDelegate = saveDelegate;
        targetTypeComboBox.Items.AddRange(_targetTypes.ToArray());
        bonusTypeComboBox.Items.AddRange(_bonusTypes.ToArray());
        effectTypeComboBox.Items.AddRange(_effectTypes.ToArray());
        targetTypeComboBox.SelectedItem = currentStat.Target.TargetType;
        bonusTypeComboBox.SelectedItem = currentStat.BonusType;
        effectTypeComboBox.SelectedItem = currentStat.EffectType;
        valueTextBox.Text = currentStat.Value;
        return ShowDialog();
    }

    public DialogResult ShowAddGlobalStatDialog(IEnumerable<string>? targetTypes, IEnumerable<string>? bonusTypes, IEnumerable<string>? effectTypes,
        IGlobalStatView.OnSave saveDelegate)
    {
        _targetTypes = targetTypes;
        _bonusTypes = bonusTypes;
        _effectTypes = effectTypes;
        _saveDelegate = saveDelegate;
        targetTypeComboBox.Items.AddRange(_targetTypes.ToArray());
        bonusTypeComboBox.Items.AddRange(_bonusTypes.ToArray());
        effectTypeComboBox.Items.AddRange(_effectTypes.ToArray());
        return ShowDialog();
    }
}
