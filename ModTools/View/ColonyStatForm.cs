using ModTools.Model.Other;
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
    private IList<string> _stringParamTypes;
    private string selectedEffect;
    private bool _hasSpecialValue;
    private SpecialValue? _specialValue;
    
    public ColonyStatForm()
    {
        InitializeComponent();
        UpdateTableLayout();
    }

    
    public DialogResult ShowAddColonyStatDialog(IEnumerable<string>? targetTypes, IEnumerable<string>? bonusTypes, IEnumerable<string>? effectTypes,
        IOnSaveView<ColonyStats>.OnSave saveDelegate)
    {
        _targetTypes = targetTypes;
        _bonusTypes = bonusTypes;
        _effectTypes = effectTypes;
        _saveDelegate = saveDelegate;
        UpdateComboBoxes();
        return ShowDialog();
    }
    
    public DialogResult ShowAddColonyStatDialog(IEnumerable<string>? targetTypes, IEnumerable<string>? bonusTypes, IEnumerable<string>? effectTypes,
        ColonyStats currentStat, IOnSaveView<ColonyStats>.OnSave saveDelegate)
    {
        _targetTypes = targetTypes;
        _bonusTypes = bonusTypes;
        _effectTypes = effectTypes;
        _saveDelegate = saveDelegate;
        UpdateComboBoxes();
        targetTypeComboBox.SelectedItem = currentStat.Target.TargetType;
        bonusTypeComboBox.SelectedItem = currentStat.BonusType;
        effectTypeComboBox.SelectedItem = currentStat.EffectType;
        valueTextBox.Text = currentStat.Value;
        var hasSpecialValue = currentStat.SpecialValue != null;
        specialValueCheckBox.Checked = hasSpecialValue;
        if (hasSpecialValue)
        {
            _specialValue = currentStat.SpecialValue;
            specialTextBox.Text = currentStat.SpecialValue?.Special;
            valueParamTextBox1.Text = currentStat.SpecialValue.ValueParam[0];
            valueParamTextBox2.Text = currentStat.SpecialValue.ValueParam[1];
            stringParamComboBox.SelectedItem = currentStat.SpecialValue.StringParam;
        }

        return ShowDialog();
    }
    
    private void UpdateComboBoxes()
    {
        if (_stringParamTypes == null || !_stringParamTypes.Any())
        {
            _stringParamTypes = Enum.GetNames(typeof(StrategicResourceType));
        }
        targetTypeComboBox.Items.Clear();
        targetTypeComboBox.Items.AddRange(_targetTypes.ToArray());
        bonusTypeComboBox.Items.Clear();
        bonusTypeComboBox.Items.AddRange(_bonusTypes.ToArray());
        effectTypeComboBox.Items.Clear();
        effectTypeComboBox.Items.AddRange(_effectTypes.ToArray());
        stringParamComboBox.Items.Clear();
        stringParamComboBox.Items.AddRange(_stringParamTypes.ToArray());
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
            stat.Value = null;
        }
        _saveDelegate?.Invoke(stat);
        Close();
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

    private void valueParam1TextChanged(object sender, EventArgs e)
    {
        var text = valueParamTextBox1.Text;
        if (_specialValue.ValueParam.Count < 1)
        {
            _specialValue.ValueParam.Add(text);
        }
        else
        {
            _specialValue.ValueParam[0] = text;
        }
    }

    private void valueParam2TextChanged(object sender, EventArgs e)
    {
        var text = valueParamTextBox2.Text;
        if (_specialValue.ValueParam.Count < 2)
        {
            _specialValue.ValueParam.Add(text);
        }
        else
        {
            _specialValue.ValueParam[1] = text;
        }
    }

    private void stringParamIndexSelectedChanged(object sender, EventArgs e)
    {
        if (stringParamComboBox.SelectedIndex < 0) return;
        var param = _stringParamTypes[stringParamComboBox.SelectedIndex];
        _specialValue.StringParam = param;
    }

    private void specialValueCheckChanged(object sender, EventArgs e)
    {
        if (_specialValue == null) _specialValue = new SpecialValue { Special = specialTextBox.Text };
        UpdateTableLayout();
    }

    private void UpdateTableLayout()
    {
        if (specialValueCheckBox.Checked)
        {
            tableLayoutPanel1.RowStyles[8].SizeType = SizeType.Absolute;
            tableLayoutPanel1.RowStyles[8].Height = 0;
            tableLayoutPanel1.RowStyles[4].SizeType = SizeType.AutoSize;
            tableLayoutPanel1.RowStyles[5].SizeType = SizeType.AutoSize;
            tableLayoutPanel1.RowStyles[6].SizeType = SizeType.AutoSize;
            tableLayoutPanel1.RowStyles[7].SizeType = SizeType.AutoSize;
        }
        else
        {
            tableLayoutPanel1.RowStyles[4].SizeType = SizeType.Absolute;
            tableLayoutPanel1.RowStyles[4].Height = 0;
            tableLayoutPanel1.RowStyles[5].SizeType = SizeType.Absolute;
            tableLayoutPanel1.RowStyles[5].Height = 0;
            tableLayoutPanel1.RowStyles[6].SizeType = SizeType.Absolute;
            tableLayoutPanel1.RowStyles[6].Height = 0;
            tableLayoutPanel1.RowStyles[7].SizeType = SizeType.Absolute;
            tableLayoutPanel1.RowStyles[7].Height = 0;
            tableLayoutPanel1.RowStyles[8].SizeType = SizeType.AutoSize;
        }
    }
}