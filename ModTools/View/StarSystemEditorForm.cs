using ModTools.Event;
using ModTools.View.Contracts;
using ReaLTaiizor.Forms;

namespace ModTools.View
{
    public partial class StarSystemEditorForm : CrownForm, IStarSystemEditorView
    {
        
        public event EventHandler<DataArg<string>>? StarSystemTypeSelected;
        public event EventHandler<DataArg<string>>? StarSelected;
        public event EventHandler<DataArg<string>>? StarNameChanged;
        public event EventHandler<DataArg<string>>? StarSystemNameChanged;
        public event EventHandler<DataArg<string>>? StarSystemDescriptionChanged;
        public event EventHandler<DataArg<string>>? CurrentStarSystemItemDoubleClicked;
        public event EventHandler<DataArg<int?>>? PositionTextChanged;
        public event EventHandler<DataArg<string>>? PlanetNameChanged;
        public event EventHandler<DataArg<int?>>? PlanetClassChanged;
        public event EventHandler<DataArg<int?>>? PlanetMineralsChanged;
        public event EventHandler<DataArg<int?>>? PlanetTechnologyChanged;
        public event EventHandler<DataArg<int?>>? PlanetWealthChanged;
        public event EventHandler<DataArg<int?>>? PlanetFertilityChanged;
        public event EventHandler<DataArg<int?>>? PlanetInfluenceChanged;
        public event EventHandler? AddOrbitLaneClicked;
        public event EventHandler? AddLaneBodyClicked;
        public event EventHandler? AddCurrentSystemClicked;
        public event EventHandler? SaveAllClicked;
        public event EventHandler<DataArg<int>>? RemoveOrbitLaneClicked;
        public event EventHandler<DataArg<int>>? RemoveLaneBodyClicked;
        public event EventHandler<DataArg<string[]>>? RemoveStarSystemClicked;
        public event EventHandler<DataArg<int?>>? OrbitLaneIndexSelected;
        public event EventHandler<DataArg<int?>>? LaneBodyIndexSelected;
        public event EventHandler<DataArg<int?>>? PlanetTraitIndexSelected;
        public event EventHandler<DataArg<int?>>? PlanetTypeIndexSelected;
        public event EventHandler<DataArg<int?>>? TabIndexSelected;
        public event EventHandler<DataArg<int?>>? ModTypeSelected;
        public event EventHandler<DataArg<int?>>? SystemToCopyIndexSelected;

        public void ShowWeight(bool show)
        {
            weightTextBox.Visible = show;
            weightLabel.Visible = show;
        }

        public bool IsReplaceMod => modTypeComboBox.SelectedItem?.Equals("Replace") ?? false;

        public StarSystemEditorForm()
        {
            InitializeComponent();
            Text = "Star System Editor";
        }

        private void starSystemGroupTypeSelected(object sender, EventArgs e)
        {
            StarSystemTypeSelected?.Invoke(sender, new DataArg<string>(starSystemGroupTypeComboBox.SelectedItem.ToString()));
        }


        public string? GetSelectedStar()
        {
            return starsComboBox.SelectedItem?.ToString();
        }

        public void SetModType(string modType)
        {
            modTypeComboBox.SelectedItem = modType;
        }

        public void AllowPlanetClassDistributionEdits(bool allow)
        {
            mineralsTextBox.Enabled = allow;
            technologyTextBox.Enabled = allow;
            wealthTextBox.Enabled = allow;
            fertilityTextBox.Enabled = allow;
            planetInfluenceTextBox.Enabled = allow;
        }

        public void SetStarSystemName(string name)
        {
            starSystemNameTextBox.Text = name;
        }

        public void SetStarSystemDescription(string description)
        {
            starSystemDescriptionTextBox.Text = description;
        }

        public void SetSystemsToCopyItems(string[] systems)
        {
            systemToCopyComboBox.Items.Clear();
            systemToCopyComboBox.Items.AddRange(systems);
        }

        public void SetStarSystemTypes(object[] systemTypes, int? defaultSelected)
        {
            starSystemGroupTypeComboBox.Items.Clear();
            starSystemGroupTypeComboBox.Items.AddRange(systemTypes);
            if (defaultSelected != null)
            {
                starSystemGroupTypeComboBox.SelectedItem = systemTypes[defaultSelected.Value];    
            }
        }

        public void SetCurrentStarSystems(string[] starSystems)
        {
            currentStarSystemsListView.Items.Clear();
            foreach (var starSystem in starSystems)
            {
                currentStarSystemsListView.Items.Add(new ListViewItem(starSystem)
                {
                    ForeColor = Color.WhiteSmoke
                });
            }
        }

        public void SetOrbitLanes(string[] orbitLanes, int? defaultSelected)
        {
            orbitLaneListView.Items.Clear();
            foreach (var orbitLane in orbitLanes)
            {
                orbitLaneListView.Items.Add(new ListViewItem(orbitLane)
                {
                    ForeColor = Color.WhiteSmoke
                });
            }

            if (defaultSelected != null)
            {
                orbitLaneListView.Items[defaultSelected.Value].Selected = true;
            }
        }

        public void SetLaneBodies(string[] laneBodies, int? defaultSelected)
        {
            laneBodyListView.Items.Clear();
            if (laneBodies != null)
            {
                foreach (var laneBody in laneBodies)
                {
                    laneBodyListView.Items.Add(new ListViewItem(laneBody)
                    {
                        ForeColor = Color.WhiteSmoke
                    });
                }    
            }
            if (defaultSelected != null)
            {
                laneBodyListView.Items[defaultSelected.Value].Selected = true;
            }
        }

        public void EnableLaneButtons(bool enable)
        {
            addLaneBodyButton.Enabled = enable;
            removeLaneBodyButton.Enabled = enable;
        }

        public void SetPlanetTypes(string[] planetTypes, int? defaultSelected = null)
        {
            planetTypeComboBox.Items.Clear();
            planetTypeComboBox.Items.AddRange(planetTypes);
            if (defaultSelected != null)
            {
                planetTypeComboBox.SelectedItem = planetTypes[defaultSelected.Value];
            }
        }

        public void SetPlanetTraits(string[] planetTraits)
        {
            planetTraitComboBox.Items.Clear();
            planetTraitComboBox.Items.AddRange(planetTraits);
        }

        public void SetPlanetName(string name)
        {
            planetNameTextBox.Text = name;
        }

        public void SetStarName(string name)
        {
            starNameTextBox.Text = name;
        }

        public void SetPlanetClass(int planetClass)
        {
            planetClassTextBox.Text = planetClass.ToString();
        }

        public void SetPlanetType(string planetType)
        {
            planetTypeComboBox.SelectedItem = planetType;
        }

        public void SetPlanetTrait(string planetTrait)
        {
            planetTraitComboBox.SelectedItem = planetTrait;
        }

        public void SetPlanetMinerals(string minerals)
        {
            mineralsTextBox.Text = minerals;
        }

        public void SetPlanetTechnology(string tech)
        {
            technologyTextBox.Text = tech;
        }

        public void SetPlanetWealth(string wealth)
        {
            wealthTextBox.Text = wealth;
        }

        public void SetPlanetFertility(string fertility)
        {
            fertilityTextBox.Text = fertility;
        }

        public void SetPlanetInflunce(string influence)
        {
            planetInfluenceTextBox.Text = influence;
        }

        public void SetStarTypes(string[] stars)
        {
            starsComboBox.Items.Clear();
            starsComboBox.Items.AddRange(stars);
        }

        public void SetSelectedStar(string star)
        {
            starsComboBox.SelectedItem = star;
        }

        public void SetBodyLabelText(string text)
        {
            bodyTypeLabel.Text = text;
        }

        public void SetPosition(string? position)
        {
            positionTextBox.Text = position;
        }

        public void ShowDescription(bool show)
        {
            starSystemDescriptionLabel.Visible = show;
            starSystemDescriptionTextBox.Visible = show;
        }

        public void ShowLaneBodies(bool show)
        {
            laneBodiesPanel.Visible = show;
        }

        public void ShowBody(bool show)
        {
            // bodyLabel.Visible = show;
            // bodyComboBox.Visible = show;
            orbitalBodyPanel.Visible = show;
        }

        public void ShowStarTable(bool show)
        {
            starTablePanel.Visible = show;
        }

        public void ShowPlanetTable(bool show)
        {
            planetTablePanel.Visible = show;
        }

        public void ShowPositionTable(bool show)
        {
            positionTablePanel.Visible = show;
        }
        
        private void removeStarSystemButtonClicked(object sender, EventArgs e)
        {
            var items = new List<string>();
            for (int i = 0; i < currentStarSystemsListView.SelectedItems.Count; i++)
            {
                items.Add(currentStarSystemsListView.SelectedItems[i].Text);
            }
            RemoveStarSystemClicked?.Invoke(sender, new DataArg<string[]>(items.ToArray()));
        }

        private void addOrbitLaneButtonClicked(object sender, EventArgs e)
        {
            AddOrbitLaneClicked?.Invoke(sender, EventArgs.Empty);
        }

        private void removeOrbitLaneButtonClicked(object sender, EventArgs e)
        {
            if (orbitLaneListView.SelectedIndices.Count > 0)
            {
                RemoveOrbitLaneClicked?.Invoke(sender, new DataArg<int>(orbitLaneListView.SelectedIndices[0]));
            }
        }

        private void addLaneBodyButtonClicked(object sender, EventArgs e)
        {
            AddLaneBodyClicked?.Invoke(sender, EventArgs.Empty);
        }

        private void removeLaneBodyButtonClicked(object sender, EventArgs e)
        {
            if (laneBodyListView.SelectedIndices.Count > 0)
            {
                RemoveLaneBodyClicked?.Invoke(sender, new DataArg<int>(laneBodyListView.SelectedIndices[0]));    
            }
        }

        private void orbitLaneSelectedIndexChanged(object sender, EventArgs e)
        {
            if (orbitLaneListView.SelectedIndices.Count > 0)
            {
                OrbitLaneIndexSelected?.Invoke(sender, new DataArg<int?>(orbitLaneListView.SelectedIndices[0]));
            }
            else
            {
                OrbitLaneIndexSelected?.Invoke(sender, new DataArg<int?>(null));
            }
        }

        private void laneBodySelectedIndexChanged(object sender, EventArgs e)
        {
            if (laneBodyListView.SelectedIndices.Count > 0)
            {
                LaneBodyIndexSelected?.Invoke(sender, new DataArg<int?>(laneBodyListView.SelectedIndices[0]));
            }
            else
            {
                LaneBodyIndexSelected?.Invoke(sender, new DataArg<int?>(null));
            }
        }


        private void starSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(starsComboBox.SelectedItem?.ToString()))
            {
                StarSelected?.Invoke(sender, new DataArg<string>(starsComboBox.SelectedItem.ToString()));   
            }
        }

        private void positionTextChanged(object sender, EventArgs e)
        {
            var text = positionTextBox.Text;
            int? number = int.TryParse(text, out int val) ? val : null;

            positionTextBox.Text = number?.ToString() ?? "";
            
            PositionTextChanged?.Invoke(sender, new DataArg<int?>(number));
        }

        private void planetNameChanged(object sender, EventArgs e)
        {
            PlanetNameChanged?.Invoke(sender, new DataArg<string>(planetNameTextBox.Text));
        }

        private void planetClassTextChanged(object sender, EventArgs e)
        {
            var number = planetClassTextBox.VerifyInt();
            PlanetClassChanged?.Invoke(sender, new DataArg<int?>(number));
        }

        private void planetTraitSelectedIndexChanged(object sender, EventArgs e)
        {
            PlanetTraitIndexSelected?.Invoke(sender, new DataArg<int?>(planetTraitComboBox.SelectedIndex));
        }

        private void planetTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            PlanetTypeIndexSelected?.Invoke(sender, new DataArg<int?>(planetTypeComboBox.SelectedIndex));
        }

        private void starNameTextChanged(object sender, EventArgs e)
        {
            StarNameChanged?.Invoke(sender, new DataArg<string>(starNameTextBox.Text));
        }

        private void addCurrentSystemClicked(object sender, EventArgs e)
        {
            AddCurrentSystemClicked?.Invoke(sender, EventArgs.Empty);
        }

        private void saveAllClicked(object sender, EventArgs e)
        {
            SaveAllClicked?.Invoke(sender, EventArgs.Empty);
        }

        private void tabSelectedIndexChanged(object sender, EventArgs e)
        {
            TabIndexSelected?.Invoke(sender, new DataArg<int?>(tabPage1.SelectedIndex));
        }

        private void systemNameTextChanged(object sender, EventArgs e)
        {
            StarSystemNameChanged?.Invoke(sender, new DataArg<string>(starSystemNameTextBox.Text));
        }

        private void starSystemDescriptionChanged(object sender, EventArgs e)
        {
            StarSystemDescriptionChanged?.Invoke(sender, new DataArg<string>(starSystemDescriptionTextBox.Text));
        }

        private void mineralsTextChanged(object sender, EventArgs e)
        {
            var number = mineralsTextBox.VerifyInt();
            PlanetMineralsChanged?.Invoke(sender, new DataArg<int?>(number));
        }

        private void technologyTextChanged(object sender, EventArgs e)
        {
            var number = technologyTextBox.VerifyInt();
            PlanetTechnologyChanged?.Invoke(sender, new DataArg<int?>(number));
        }

        private void wealthTextChanged(object sender, EventArgs e)
        {
            var number = wealthTextBox.VerifyInt();
            PlanetWealthChanged?.Invoke(sender, new DataArg<int?>(number));
        }

        private void fertilityTextChanged(object sender, EventArgs e)
        {
            var number = fertilityTextBox.VerifyInt();
            PlanetFertilityChanged?.Invoke(sender, new DataArg<int?>(number));
        }

        private void influenceTextChanged(object sender, EventArgs e)
        {
            var number = planetInfluenceTextBox.VerifyInt();
            PlanetInfluenceChanged?.Invoke(sender, new DataArg<int?>(number));
        }
        
        private void modTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            ModTypeSelected?.Invoke(sender, new DataArg<int?>(modTypeComboBox.SelectedIndex));
        }

        private void systemToCopySelectedIndexChanged(object sender, EventArgs e)
        {
            SystemToCopyIndexSelected?.Invoke(sender, new DataArg<int?>(systemToCopyComboBox.SelectedIndex));
        }

        private void currentStarSystemItemDoubleClicked(object sender, EventArgs e)
        {
            CurrentStarSystemItemDoubleClicked?.Invoke(sender, new DataArg<string>(currentStarSystemsListView.SelectedItems[0].Text));
        }
    }
}
