using ModTools.Event;
using ModTools.Model.EffectType;
using ModTools.Model.Race;
using ModTools.Services.Contracts;
using ModTools.View.Contracts;
using ReaLTaiizor.Forms;
using Image = System.Drawing.Image;

namespace ModTools.View
{
    public partial class RaceEditorForm : CrownForm, IRaceEditorView
    {

        public string ProtestingApprovalValue => protestingApprovalThresholdTextBox.Text;
        public string IdeologyChanceValue => ideologyChanceTextBox.Text;
        public string CriminalChanceValue => criminalChanceTextBox.Text;
        public string EmporiumChanceValue => emporiumChanceTextBox.Text;
        public string NaturalLeagueChanceValue => naturalLeagueChanceTextBox.Text;
        public string PacifistChanceValue => pacifistChanceTextBox.Text;
        public string WarforgedChanceValue => warforgedChanceTextBox.Text;
        public string EnteredName => nameTextBox.Text;
        public string EnteredDescription => descriptionTextBox.Text;
        public bool IsMinorRaceChecked => IsMinorRaceCheckBox.Checked;
        public bool IsHasGenderChecked => hasGenderCheckBox.Checked;
        public bool IsReplaceMod => modTypeComboBox.SelectedItem?.Equals("Replace") ?? false;

        public string GlobalStatSelected => globalStatslistView.SelectedItems[0]?.Text ?? "";
        public string ColonyStatSelected => colonyStatsListView.SelectedItems[0]?.Text ?? "";
        public string ApprovalModifierSelected => approvalModifiersListView.SelectedItems[0]?.Text ?? "";
        public string? ConsumedTraitSelected => consumedTraitComboBox.SelectedItem.ToString();
        public string? DefaultTraitsSelected => defaultTraitsComboBox.SelectedItem.ToString();
        public event EventHandler? SaveRaceClicked;
        public event EventHandler? AddApprovalModifiersClicked;
        public event EventHandler? RemoveApprovalModifiersClicked;
        public event EventHandler? AddColonyStatClicked;
        public event EventHandler? RemoveColonyStatClicked;
        public event EventHandler? AddGlobalStatClicked;
        public event EventHandler? RemoveGlobalStatClicked;
        public event EventHandler? PoliticalAdvisorPortraitClicked;
        public event EventHandler? ColonizationAdvisorPortraitClicked;
        public event EventHandler? ScienceAdvisorPortraitClicked;
        public event EventHandler? MilitaryAdvisorPortraitClicked;
        public event EventHandler? GenericImagePortraitClicked;
        public event EventHandler? SetModFolderButtonClicked;
        public event EventHandler? ManagePortraitsButtonClicked;
        public event EventHandler<DataArg<string>>? GlobalStatsDoubleClicked;
        public event EventHandler<DataArg<string>>? ColonyStatsDoubleClicked;
        public event EventHandler<DataArg<string>>? ApprovalModifiersDoubleClicked;
        public event EventHandler<DataArg<string>>? RaceDropDownSelected;
        public event EventHandler? SetGameInstallFolderClicked;
        public event EventHandler<DataArg<string>>? DefaultTraitSelected;
        public event EventHandler<DataArg<string>>? ConsumedTraitComboSelected;
        public event EventHandler<DataArg<string>>? NameTextChanged;
        public event EventHandler<DataArg<string>>? DescriptionTextChanged;
        public event EventHandler<DataArg<bool>>? IsMinorRaceCheckChanged;
        public event EventHandler<DataArg<bool>>? HasGenderCheckChanged;
        public event EventHandler<DataArg<double?>>? ProtestingApprovalThresholdTextChanged;
        public event EventHandler<DataArg<double?>>? IdeologyChanceTextChanged;
        public event EventHandler<DataArg<double?>>? CriminalChanceTextChanged;
        public event EventHandler<DataArg<double?>>? EmporiumChanceTextChanged;
        public event EventHandler<DataArg<double?>>? NaturalLeagueChanceTextChanged;
        public event EventHandler<DataArg<double?>>? PacifistChanceTextChanged;
        public event EventHandler<DataArg<double?>>? WarforgedChanceTextChanged;

        private readonly IImageService _imageService;

        public RaceEditorForm(IImageService imageService)
        {
            _imageService = imageService;
            InitializeComponent();
            tabPage1.SelectedIndex = 3;
            modTypeComboBox.SelectedIndex = 0;
        }

        public void SetDefaultTraits(IEnumerable<string>? defaultTraits)
        {
            defaultTraitsComboBox.Items.Clear();
            defaultTraitsComboBox.Items.AddRange(defaultTraits.ToArray());
        }

        public void SetDefaultTrait(string trait)
        {
            defaultTraitsComboBox.SelectedItem = trait;
        }

        public void SetConsumedTraits(IEnumerable<string>? consumedTraits)
        {
            consumedTraitComboBox.Items.Clear();
            consumedTraitComboBox.Items.AddRange(consumedTraits.ToArray());
        }

        public void SetConsumedTrait(string trait)
        {
            consumedTraitComboBox.SelectedItem = trait;
        }

        public void SetBaseRaces(IEnumerable<string> races)
        {
            raceComboBox.Items.Clear();
            raceComboBox.Items.AddRange(races.ToArray());
        }
        
        private void RaceDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            RaceDropDownSelected?.Invoke(this, new DataArg<string>(raceComboBox.SelectedItem?.ToString() ?? ""));
        }

        public void UpdateUi(string basePath, CitizenRace race)
        {
            genericImagePictureBox.Image?.Dispose();
            militaryAdvisorPortraitPictureBox.Image?.Dispose();
            scienceAdvisorPortraitPictureBox.Image?.Dispose();
            colonizationAdvisorPortraitPictureBox.Image?.Dispose();
            politicalAdvisorPortraitPictureBox.Image?.Dispose();
            nameTextBox.Text = race.Name_Parsed;
            descriptionTextBox.Text = race.Description_Desired;
            IsMinorRaceCheckBox.Checked = race.IsMinorRace;
            hasGenderCheckBox.Checked = race.HasGender;
            var image = _imageService.LoadCitizenImage(basePath, race.Name_Parsed, race.GenericImage, race.GenericImageFullPath, race.InternalName);
            genericImagePictureBox.Image = image.Image;
            race.GenericImageFullPath = image.Path;
            race.GenericImage = Path.GetFileName(image.Path);
            
            image = _imageService.LoadCitizenImage(basePath, race.Name_Parsed, race.MilitaryAdvisorPortrait, race.MilitaryAdvisorPortraitFullPath, race.InternalName);
            militaryAdvisorPortraitPictureBox.Image = image.Image;
            race.MilitaryAdvisorPortraitFullPath = image.Path;
            race.MilitaryAdvisorPortrait = Path.GetFileName(image.Path);

            image = _imageService.LoadCitizenImage(basePath, race.Name_Parsed, race.ScienceAdvisorPortrait, race.ScienceAdvisorPortraitFullPath, race.InternalName);
            scienceAdvisorPortraitPictureBox.Image = image.Image;
            race.ScienceAdvisorPortraitFullPath = image.Path;
            race.ScienceAdvisorPortrait = Path.GetFileName(image.Path);

            image = _imageService.LoadCitizenImage(basePath, race.Name_Parsed, race.ColonizationAdvisorPortrait, race.ColonizationAdvisorPortraitFullPath, race.InternalName);
            colonizationAdvisorPortraitPictureBox.Image = image.Image;
            race.ColonizationAdvisorPortraitFullPath = image.Path;
            race.ColonizationAdvisorPortrait = Path.GetFileName(image.Path);

            image = _imageService.LoadCitizenImage(basePath, race.Name_Parsed, race.PoliticalAdvisorPortrait, race.PoliticalAdvisorPortraitFullPath, race.InternalName);
            politicalAdvisorPortraitPictureBox.Image = image.Image;
            race.PoliticalAdvisorPortraitFullPath = image.Path;
            race.PoliticalAdvisorPortrait = Path.GetFileName(image.Path);

            protestingApprovalThresholdTextBox.Text = race.ProtestingApprovalThreshold;
            ideologyChanceTextBox.Text = race.IdeologyChance;
            criminalChanceTextBox.Text = race.CriminalChance;
            emporiumChanceTextBox.Text = race.EmporiumChance;
            naturalLeagueChanceTextBox.Text = race.NaturalLeagueChance;
            pacifistChanceTextBox.Text = race.PacifistChance;
            warforgedChanceTextBox.Text = race.WarforgedChance;

            ConfigureGlobalStatsListView(race);
            ConfigureColonyStatsListView(race);
            ConfigureApprovalModifiersListView(race);
            
            var index = defaultTraitsComboBox.Items.IndexOf(race.DefaultTraits ?? "");
            defaultTraitsComboBox.SelectedIndex = index; 

            index = consumedTraitComboBox.Items.IndexOf(race.ConsumedTrait ?? "");
            consumedTraitComboBox.SelectedIndex = index;
        }

        private void ConfigureColonyStatsListView(CitizenRace race)
        {
            colonyStatsListView.Items.Clear();
            var imageList = new ImageList();
            imageList.ImageSize = new Size(24, 24);
            imageList.TransparentColor = Color.Transparent;
            if (colonyStatsListView.SmallImageList != null && colonyStatsListView.SmallImageList.Images.Count > 0)
            {
                // Clean up old images
                foreach (Image image in colonyStatsListView.SmallImageList.Images)
                {
                    image.Dispose();
                }
                colonyStatsListView.SmallImageList.Images.Clear();
            }

            var statsIndexed = race.ColonyStats.Select((item, index) => (item, index));
            foreach (var (stat, index) in statsIndexed)
            {
                var effectType = EffectType.FromInternalName(stat.EffectType);
                var bitmap = effectType.LoadIconBitmap();
                
                imageList.Images.Add(effectType.InternalName, bitmap);
                var items = new string[5];
                items[0] = stat.Value ?? "";
                items[1] = stat.ValueType;
                items[2] = stat.SpecialValue?.StringParam ?? "";
                items[3] = stat.SpecialValue?.ValueParam?[0] ?? "";
                items[4] = stat.SpecialValue?.ValueParam?[1] ?? "";
                var item = NewStatListItem(stat.EffectType, index, items);
                colonyStatsListView.Items.Add(item);
            }
            colonyStatsListView.SmallImageList = imageList;
        }
        
        private void ConfigureApprovalModifiersListView(CitizenRace race)
        {
            approvalModifiersListView.Items.Clear();
            var imageList = new ImageList();
            imageList.ImageSize = new Size(24, 24);
            imageList.TransparentColor = Color.Transparent;
            
            var statsIndexed = race.ApprovalModifiers.Select((item, index) => (item, index));
            foreach (var (stat, index) in statsIndexed)
            {
                var item = NewStatListItem(stat.Type, -1, stat.Tag ?? "", stat.Value ?? "");
                approvalModifiersListView.Items.Add(item);
            }
        }

        private static ListViewItem NewStatListItem(string statName, int index, params string[] value)
        {
            var item = new ListViewItem(statName)
            {
                ImageIndex = index,
                ForeColor = Color.WhiteSmoke,
                Font = new Font(FontFamily.GenericSerif, 12)
            };
            item.SubItems.AddRange(value);
            return item;
        }

        private void ConfigureGlobalStatsListView(CitizenRace race)
        {
            globalStatslistView.Items.Clear();
            var imageList = new ImageList();
            imageList.ImageSize = new Size(24, 24);
            imageList.TransparentColor = Color.Transparent;
            if (globalStatslistView.SmallImageList != null && globalStatslistView.SmallImageList.Images.Count > 0)
            {
                // Clean up old images
                foreach (Image image in globalStatslistView.SmallImageList.Images)
                {
                    image.Dispose();
                }
                globalStatslistView.SmallImageList.Images.Clear();
            }

            var statsIndexed = race.GlobalStats.Select((item, index) => (item, index));
            foreach (var (stat, index) in statsIndexed)
            {
                var effectType = EffectType.FromInternalName(stat.EffectType);
                var bitmap = effectType.LoadIconBitmap();
                
                imageList.Images.Add(effectType.InternalName, bitmap);
                var item = NewStatListItem(stat.EffectType, index, stat.Value);
                globalStatslistView.Items.Add(item);
            }
            globalStatslistView.SmallImageList = imageList;
        }

        private void genericImagePictureBox_Click(object sender, EventArgs e)
        {
            GenericImagePortraitClicked?.Invoke(this, EventArgs.Empty);
        }

        private void militaryAdvisorPortraitPictureBox_Click(object sender, EventArgs e)
        {
            MilitaryAdvisorPortraitClicked?.Invoke(this, EventArgs.Empty);
        }

        private void scienceAdvisorPortraitPictureBox_Click(object sender, EventArgs e)
        {
            ScienceAdvisorPortraitClicked?.Invoke(this, EventArgs.Empty);
        }

        private void colonizationAdvisorPortraitPictureBox_Click(object sender, EventArgs e)
        {
            ColonizationAdvisorPortraitClicked?.Invoke(this, EventArgs.Empty);
        }

        private void politicalAdvisorPortraitPictureBox_Click(object sender, EventArgs e)
        {
            PoliticalAdvisorPortraitClicked?.Invoke(this, EventArgs.Empty);
        }

        private void addGlobalStatButton_Click(object sender, EventArgs e)
        {
            AddGlobalStatClicked?.Invoke(this, EventArgs.Empty);
        }

        private void removeGlobalStatButton_Click(object sender, EventArgs e)
        {
            RemoveGlobalStatClicked?.Invoke(this, EventArgs.Empty);
        }

        private void addColonyStatButton_Click(object sender, EventArgs e)
        {
            AddColonyStatClicked?.Invoke(this, EventArgs.Empty);
        }

        private void removeColonyStatButton_Click(object sender, EventArgs e)
        {
            RemoveColonyStatClicked?.Invoke(this, EventArgs.Empty);
        }

        private void addApprovalModifiersButton_Click(object sender, EventArgs e)
        {
            AddApprovalModifiersClicked?.Invoke(this, EventArgs.Empty);
        }

        private void removeApprovalModifiersButton_Click(object sender, EventArgs e)
        {
            RemoveApprovalModifiersClicked?.Invoke(this, EventArgs.Empty);
        }

        private void saveRaceButton_Click(object sender, EventArgs e)
        {
            genericImagePictureBox.Image?.Dispose();
            militaryAdvisorPortraitPictureBox.Image?.Dispose();
            scienceAdvisorPortraitPictureBox.Image?.Dispose();
            colonizationAdvisorPortraitPictureBox.Image?.Dispose();
            politicalAdvisorPortraitPictureBox.Image?.Dispose();
            SaveRaceClicked?.Invoke(this, EventArgs.Empty);
        }

        private void protestingApprovalTextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            var number = textbox.VerifyDouble();
            ProtestingApprovalThresholdTextChanged?.Invoke(sender, new DataArg<double?>(number));
        }

        private void ideologyChanceTextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            var number = textbox.VerifyDouble();
            IdeologyChanceTextChanged?.Invoke(sender, new DataArg<double?>(number));
        }

        private void criminalChanceTextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            var number = textbox.VerifyDouble();
            CriminalChanceTextChanged?.Invoke(sender, new DataArg<double?>(number));
        }

        private void emporiumChanceTextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            var number = textbox.VerifyDouble();
            EmporiumChanceTextChanged?.Invoke(sender, new DataArg<double?>(number));
        }

        private void naturalLeagueChanceTextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            var number = textbox.VerifyDouble();
            NaturalLeagueChanceTextChanged?.Invoke(sender, new DataArg<double?>(number));
        }

        private void pacifistChanceTextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            var number = textbox.VerifyDouble();
            PacifistChanceTextChanged?.Invoke(sender, new DataArg<double?>(number));
        }

        private void warforgedChanceTextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            var number = textbox.VerifyDouble();
            WarforgedChanceTextChanged?.Invoke(sender, new DataArg<double?>(number));
        }

        private void defaultTraitSelected(object sender, EventArgs e)
        {
            DefaultTraitSelected?.Invoke(sender, new DataArg<string>(defaultTraitsComboBox.SelectedItem.ToString() ?? ""));
        }

        private void consumedTraitSelected(object sender, EventArgs e)
        {
            ConsumedTraitComboSelected?.Invoke(sender, new DataArg<string>(consumedTraitComboBox.SelectedItem.ToString() ?? ""));
        }

        private void addGlobalStatsButtonHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(addGlobalStatButton, "Add a global stat to the current race");
        }

        private void removeGlobalStatButtonHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(removeGlobalStatButton, "Remove the selected global stat from the current race");
        }

        private void addColonyStatButtonHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(addColonyStatButton, "Add a colony stat to the current race");
        }

        private void removeColonyStatButtonHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(removeColonyStatButton, "Remove the selected colony stat from the current race");
        }

        private void addApprovalModifiersButtonHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(addApprovalModifiersButton, "Add an approval modifier to the current race");
        }

        private void removeApprovalModifiersButtonHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(removeApprovalModifiersButton, "Remove the selected approval modifier from the current race");
        }

        private void nameTextChanged(object sender, EventArgs e)
        {
            NameTextChanged?.Invoke(sender, new DataArg<string>(nameTextBox.Text));
        }

        private void descriptionTextChanged(object sender, EventArgs e)
        {
            DescriptionTextChanged?.Invoke(sender, new DataArg<string>(descriptionTextBox.Text));
        }

        private void isMinorRaceCheckChanged(object sender, EventArgs e)
        {
            IsMinorRaceCheckChanged?.Invoke(sender, new DataArg<bool>(IsMinorRaceCheckBox.Checked));
        }

        private void hasGenderCheckChanged(object sender, EventArgs e)
        {
            HasGenderCheckChanged?.Invoke(sender, new DataArg<bool>(hasGenderCheckBox.Checked));
        }

        private void globalStatsDoubleClicked(object? sender, EventArgs e)
        {
            GlobalStatsDoubleClicked?.Invoke(sender, new DataArg<string>(globalStatslistView.SelectedItems[0].SubItems[0].Text));
        }

        private void approvalModifiersDoubleClicked(object sender, EventArgs e)
        {
            ApprovalModifiersDoubleClicked?.Invoke(sender, new DataArg<string>(approvalModifiersListView.SelectedItems[0].SubItems[0].Text));
        }

        private void colonyStatsDoubleClicked(object sender, EventArgs e)
        {
            ColonyStatsDoubleClicked?.Invoke(sender, new DataArg<string>(colonyStatsListView.SelectedItems[0].SubItems[0].Text));
        }

        private void managePortraitsClicked(object sender, EventArgs e)
        {
            ManagePortraitsButtonClicked?.Invoke(sender, e);
        }
    }
}