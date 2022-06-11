using ModTools.Event;
using ModTools.View.Contracts;
using ReaLTaiizor.Forms;

namespace ModTools.View
{
    public partial class EventEditorForm : CrownForm, IEventEditorView
    {
        
        public event EventHandler? AddBackgroundImageClicked;
        public event EventHandler? BackgroundImageClicked;
        public event EventHandler? AddChoiceClicked;
        public event EventHandler? AddCurrentEventClicked;
        public event EventHandler? SaveAllClicked;
        public event EventHandler<DataArg<int?>>? RemoveChoiceClicked;
        public event EventHandler<DataArg<int[]?>>? RemoveCurrentEventsClicked;
        public event EventHandler<DataArg<int?>>? ModTypeSelected;
        public event EventHandler<DataArg<int?>>? EventTypeSelected;
        public event EventHandler<DataArg<int?>>? CulturalAlignmentTypeSelected;
        public event EventHandler<DataArg<int?>>? ChoiceSelected;
        public event EventHandler<DataArg<string>>? WeightTextChanged;
        public event EventHandler<DataArg<string>>? EventNameTextChanged;
        public event EventHandler<DataArg<string>>? WindowTitleTextChanged;
        public event EventHandler<DataArg<string>>? EventDescriptionTextChanged;
        public event EventHandler<DataArg<string?>>? ChoiceDescriptionTextChanged;
        public event EventHandler<DataArg<string?>>? ChoiceBonusDescriptionTextChanged;
        public event EventHandler<DataArg<bool>>? ShouldInterruptOtherScreensCheckedChanged;
        public event EventHandler<DataArg<bool>>? ShowImmediatelyCheckedChanged;
        
        
        public EventEditorForm()
        {
            InitializeComponent();
        }
        
        
        
        public void SetModType(string modType)
        {
            modTypeComboBox.SelectedItem = modType;
        }

        public void SetEventType(string eventType)
        {
            eventTypeComboBox.SelectedItem = eventType;
        }

        public void SetWeight(string weight)
        {
            weightTextBox.Text = weight;
        }

        public void SetShouldInterruptOtherScreensChecked(bool isChecked)
        {
            shouldInterruptOtherScreensCheckBox.Checked = isChecked;
        }

        public void SetShowImmediately(bool showImmediately)
        {
            showImmediatelyCheckBox.Checked = showImmediately;
        }

        public void SetEventName(string eventName)
        {
            eventNameTextBox.Text = eventName;
        }

        public void SetWindowTitle(string windowTitle)
        {
            windowTitleTextBox.Text = windowTitle;
        }

        public void SetEventDescription(string eventDescription)
        {
            eventDescriptionTextBox.Text = eventDescription;
        }

        public void SetBackgroundImage(string imagePath)
        {
            // TODO - Load image and set on backgroundPictureBox
        }

        public void SetCulturalAlignmentType(string type)
        {
            culturalAlignmentTypeComboBox.SelectedItem = type;
        }

        public void SetChoiceDescription(string description)
        {
            choiceDescriptionTextBox.Text = description;
        }

        public void SetChoiceBonusDescription(string bonusDescription)
        {
            choiceBonusDescriptionTextBox.Text = bonusDescription;
        }

        public void SetChoicesList(string[] choices)
        {
            choicesListView.Items.Clear();
            choicesListView.Items.AddRange(choices.Select(ch => new ListViewItem(ch)
            {
                ForeColor = Color.WhiteSmoke
            }).ToArray());
        }

        public void SetEventTypes(IEnumerable<string> types)
        {
            eventTypeComboBox.Items.Clear();
            eventTypeComboBox.Items.AddRange(types.ToArray());
        }

        private void addCurrentEventButtonClicked(object sender, EventArgs e)
        {
            AddCurrentEventClicked?.Invoke(sender, EventArgs.Empty);
        }

        private void saveAllButtonClicked(object sender, EventArgs e)
        {
            SaveAllClicked?.Invoke(sender, EventArgs.Empty);
        }

        private void removeEventsButtonClicked(object sender, EventArgs e)
        {
            var selected = currentEventsListView.SelectedIndices;
            var array = new int[selected.Count];
            selected.CopyTo(array, 0);
            RemoveCurrentEventsClicked?.Invoke(sender, new DataArg<int[]?>(array));
        }

        private void eventTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            EventTypeSelected?.Invoke(sender, new DataArg<int?>(eventTypeComboBox.SelectedIndex));
        }

        private void eventNameTextChanged(object sender, EventArgs e)
        {
            EventNameTextChanged?.Invoke(sender, new DataArg<string>(eventNameTextBox.Text));
        }

        private void eventDescriptionTextChanged(object sender, EventArgs e)
        {
            EventDescriptionTextChanged?.Invoke(sender, new DataArg<string>(eventDescriptionTextBox.Text));
        }

        private void weightTextChanged(object sender, EventArgs e)
        {
            WeightTextChanged?.Invoke(sender, new DataArg<string>(weightTextBox.Text));
        }

        private void addBackgroundImageButtonClicked(object sender, EventArgs e)
        {
            AddBackgroundImageClicked?.Invoke(sender, EventArgs.Empty);
        }

        private void backgoundPictureBoxClicked(object sender, EventArgs e)
        {
            BackgroundImageClicked?.Invoke(sender, EventArgs.Empty);
        }

        private void shouldInterruptOtherScreensCheckChanged(object sender, EventArgs e)
        {
            ShouldInterruptOtherScreensCheckedChanged?.Invoke(sender, new DataArg<bool>(shouldInterruptOtherScreensCheckBox.Checked));
        }

        private void showImmediatelyCheckChanged(object sender, EventArgs e)
        {
            ShowImmediatelyCheckedChanged?.Invoke(sender, new DataArg<bool>(showImmediatelyCheckBox.Checked));
        }

        private void culturalAlignmentTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            CulturalAlignmentTypeSelected?.Invoke(sender, new DataArg<int?>(culturalAlignmentTypeComboBox.SelectedIndex));
        }

        private void choiceDescriptionTextChanged(object sender, EventArgs e)
        {
            ChoiceDescriptionTextChanged?.Invoke(sender, new DataArg<string?>(choiceDescriptionTextBox.Text));
        }

        private void choiceBonusDescriptionTextChanged(object sender, EventArgs e)
        {
            ChoiceBonusDescriptionTextChanged?.Invoke(sender, new DataArg<string?>(choiceBonusDescriptionTextBox.Text));
        }

        public void SetCulturalAlignmentTypes(IEnumerable<string> types)
        {
            culturalAlignmentTypeComboBox.Items.Clear();
            culturalAlignmentTypeComboBox.Items.AddRange(types.ToArray());
        }

        private void modTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            ModTypeSelected?.Invoke(sender, new DataArg<int?>(modTypeComboBox.SelectedIndex));
        }

        private void windowTitleTextChanged(object sender, EventArgs e)
        {
            WindowTitleTextChanged?.Invoke(sender, new DataArg<string>(windowTitleTextBox.Text));
        }

        private void addChoiceButtonClicked(object sender, EventArgs e)
        {
            AddChoiceClicked?.Invoke(sender, EventArgs.Empty);
        }

        private void removeChoiceButtonClicked(object sender, EventArgs e)
        {
            var selected = choicesListView.SelectedIndices;
            var array = new int[selected.Count];
            selected.CopyTo(array, 0);
            RemoveChoiceClicked?.Invoke(sender, new DataArg<int?>(array[0]));
        }
    }
}
