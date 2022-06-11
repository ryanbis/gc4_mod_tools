using System.Drawing.Drawing2D;
using ModTools.Model.Events;
using ModTools.Model.Race;
using ModTools.View.Contracts;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Windows.Forms;

namespace ModTools.View;

public partial class GlobalStatForm : CrownForm, IGlobalStatView
{
    private IEnumerable<string>? _gameUsedTargetTypes;
    private string _selectedTarget;
    private IEnumerable<string>? _gameUsedBonusTypes;
    private string _selectedBonus;
    private IEnumerable<string>? _gameUsedEffectTypes;
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

    public DialogResult ShowAddGlobalStatDialog(IEnumerable<string>? gameUsedTargetTypes, IEnumerable<string>? gameUsedBonusTypes, IEnumerable<string>? gameUsedEffectTypes,
        GlobalStats currentStat, IOnSaveView<GlobalStats>.OnSave saveDelegate)
    {
        _gameUsedTargetTypes = gameUsedTargetTypes;
        _gameUsedBonusTypes = gameUsedBonusTypes;
        _gameUsedEffectTypes = gameUsedEffectTypes;
        _saveDelegate = saveDelegate;
        UpdateComboBoxes();
        targetTypeComboBox.SelectedItem = currentStat.Target.TargetType;
        bonusTypeComboBox.SelectedItem = currentStat.BonusType;
        effectTypeComboBox.SelectedItem = currentStat.EffectType;
        valueTextBox.Text = currentStat.Value;
        return ShowDialog();
    }

    public DialogResult ShowAddGlobalStatDialog(IEnumerable<string>? gameUsedTargetTypes, IEnumerable<string>? gameUsedBonusTypes, IEnumerable<string>? gameUsedEffectTypes,
        IGlobalStatView.OnSave saveDelegate)
    {
        _gameUsedTargetTypes = gameUsedTargetTypes;
        _gameUsedBonusTypes = gameUsedBonusTypes;
        _gameUsedEffectTypes = gameUsedEffectTypes;
        _saveDelegate = saveDelegate;
        UpdateComboBoxes();
        bonusTypeComboBox.SelectedIndex = 0;
        return ShowDialog();
    }

    private void UpdateComboBoxes()
    {
        var data = Utils.ProcessInGameList<TargetType>(_gameUsedTargetTypes, out _gameUsedTargetTypes);
        targetTypeComboBox.Items.Clear();
        targetTypeComboBox.Items.AddRange(data);

        data = Utils.ProcessInGameList<ModifierBonusType>(_gameUsedBonusTypes, out _gameUsedBonusTypes);
        bonusTypeComboBox.Items.Clear();
        bonusTypeComboBox.Items.AddRange(data);

        data = Utils.ProcessInGameList<StatType>(_gameUsedEffectTypes, out _gameUsedEffectTypes);
        effectTypeComboBox.Items.Clear();
        effectTypeComboBox.Items.AddRange(data);
    }

    private Color? targetTypeComboBoxDrawItem(object sender, DrawItemEventArgs e)
    {
        return Utils.getTextColorForModCrownComboBox(sender, e, _gameUsedTargetTypes);
    }

    private Color? bonusTypeComboBoxDrawItem(object sender, DrawItemEventArgs e)
    {
        return Utils.getTextColorForModCrownComboBox(sender, e, _gameUsedBonusTypes);
    }

    private Color? effectTypeComboBoxDrawItem(object sender, DrawItemEventArgs e)
    {
        return Utils.getTextColorForModCrownComboBox(sender, e, _gameUsedEffectTypes);
    }
    
}
