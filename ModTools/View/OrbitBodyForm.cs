using ModTools.Event;
using ModTools.View.Contracts;
using ReaLTaiizor.Forms;


namespace ModTools.View
{
    public partial class OrbitBodyForm : CrownForm, IOrbitBodyView
    {
        public event EventHandler? SaveClicked;
        public event EventHandler<DataArg<string?>>? BodyTypeSelected;
        
        
        public OrbitBodyForm()
        {
            InitializeComponent();
        }

        public DialogResult ShowOrbitLaneDialog(IEnumerable<string> bodyTypes)
        {
            bodyTypeComboBox.Items.Clear();
            bodyTypeComboBox.Items.AddRange(bodyTypes.ToArray());
            return ShowDialog();
        }

        public void ShowHomePlanetCheckbox(bool show)
        {
            isHomeworldTablePanel.Visible = show;
        }

        public bool? GetIsHomePlanetChecked()
        {
            if (!isHomeworldTablePanel.Visible) return null;
            return isHomeworldCheckBox.Checked;
        }

        public string? GetBodyTypeSelected()
        {
            var val = (string) null!;
            if (!string.IsNullOrWhiteSpace(bodyTypeComboBox.SelectedItem?.ToString()))
            {
                val = bodyTypeComboBox.SelectedItem.ToString();
            }

            return val;
        }

        private void bodyTypeIndexSelected(object sender, EventArgs e)
        {
            var val = (string) null!;
            if (!string.IsNullOrWhiteSpace(bodyTypeComboBox.SelectedItem?.ToString()))
            {
                val = bodyTypeComboBox.SelectedItem.ToString();
            }
            BodyTypeSelected?.Invoke(sender, new DataArg<string?>(val));
        }

        private void saveButtonClicked(object sender, EventArgs e)
        {
            SaveClicked?.Invoke(sender, EventArgs.Empty);
        }
    }
}
