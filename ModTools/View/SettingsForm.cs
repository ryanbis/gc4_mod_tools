using ModTools.View.Contracts;
using ReaLTaiizor.Forms;


namespace ModTools.View
{
    public partial class SettingsForm : CrownForm, ISettingsView
    {
        
        public event EventHandler? SetGameInstallPathClicked;
        public event EventHandler? SetModFolderPathClicked;
        
        
        public SettingsForm()
        {
            InitializeComponent();
        }

        public void SetGameInstallPath(string path)
        {
            gameInstallPathLabel.Text = path;
        }

        public void SetModFolderPath(string path)
        {
            modFolderPathLabel.Text = path;
        }

        private void setGameInstallPathClicked(object sender, EventArgs e)
        {
            SetGameInstallPathClicked?.Invoke(sender, EventArgs.Empty);
        }

        private void setModFolderPathClicked(object sender, EventArgs e)
        {
            SetModFolderPathClicked?.Invoke(sender, EventArgs.Empty);
        }
    }
}
