using ModTools.Event;
using ModTools.View.Contracts;
using ReaLTaiizor.Forms;

namespace ModTools.View
{
    public partial class OrbitLaneForm : CrownForm, IOrbitLaneView
    {
        
        public event EventHandler? SaveClicked;
        public event EventHandler<DataArg<string?>>? LaneTypeSelected;


        public OrbitLaneForm()
        {
            InitializeComponent();
        }
        

        public DialogResult ShowOrbitLaneDialog(IEnumerable<string> laneTypes)
        {
            laneTypeComboBox.Items.Clear();
            laneTypeComboBox.Items.AddRange(laneTypes.ToArray());
            return ShowDialog();
        }

        public void ShowMinMaxPlanets(bool show)
        {
            minMaxPlanetsTablePanel.Visible = show;
        }

        public string? GetLaneType()
        {
            if (laneTypeComboBox.SelectedItem == null) return null;
            return laneTypeComboBox.SelectedItem.ToString();
        }

        public int? GetMinPlanets()
        {
            if (string.IsNullOrWhiteSpace(minPlanetsTextBox.Text)) return null;
            return int.Parse(minPlanetsTextBox.Text);
        }

        public int? GetMaxPlanets()
        {
            if (string.IsNullOrWhiteSpace(maxPlanetsTextBox.Text)) return null;
            return int.Parse(maxPlanetsTextBox.Text);
        }

        private void saveButtonClicked(object sender, EventArgs e)
        {
            SaveClicked?.Invoke(sender, EventArgs.Empty);
        }

        private void laneTypeSelected(object sender, EventArgs e)
        {
            LaneTypeSelected?.Invoke(sender, new DataArg<string?>(laneTypeComboBox.SelectedItem?.ToString()));
        }
    }
}
