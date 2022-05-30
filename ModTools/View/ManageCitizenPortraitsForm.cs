using Microsoft.Extensions.DependencyInjection;
using ModTools.Event;
using ModTools.Services.Contracts;
using ModTools.View.Contracts;
using ReaLTaiizor.Forms;


namespace ModTools.View
{
    public partial class ManageCitizenPortraitsForm : CrownForm, IManageCitizenPortraitsView
    {
        private readonly IImageService _imageService;
        private readonly IServiceProvider _serviceProvider;
        
        private List<string> portraitPaths;
        private ImageList _imageList;
        
        public event IManageCitizenPortraitsView.OnSave? OnSaved;
        public event EventHandler? AddCitizenPortraitsClicked;
        public event EventHandler<DataArg<IEnumerable<string>>>? RemoveCitizenPortraitsClicked;


        public ManageCitizenPortraitsForm(IImageService imageService, IServiceProvider serviceProvider)
        {
            _imageService = imageService;
            _serviceProvider = serviceProvider;
            _imageList = new ImageList();
            _imageList.ImageSize = new Size(128, 128);
            _imageList.ColorDepth = ColorDepth.Depth32Bit;
            InitializeComponent();
            Text = "Manage Citizen Portraits";
        }
        


        private void addCitizenPortraitClicked(object sender, EventArgs e)
        {
            AddCitizenPortraitsClicked?.Invoke(sender, e);
        }

        private void removeCitizenPortraitsClicked(object sender, EventArgs e)
        {
            var selectedItems = new List<string>();
            foreach (ListViewItem item in citizenPortraitListView.SelectedItems)
            {
                selectedItems.Add(item.Text);
            }
            RemoveCitizenPortraitsClicked?.Invoke(sender, new DataArg<IEnumerable<string>>(selectedItems));
        }
        

        public void RefreshPaths(IEnumerable<string> citizenPortraitPaths)
        {
            portraitPaths = citizenPortraitPaths.ToList();
            UpdateUi();
        }

        private void UpdateUi()
        {
            if (!_imageList.Images.Empty)
            {
                foreach (Image listImage in _imageList.Images)
                {
                    listImage.Dispose();
                }
                _imageList.Images.Clear();
            }
            var newPathList = new List<string>();
            citizenPortraitListView.Items.Clear();
            if (portraitPaths.Count > 0)
            {
                for (var i = 0; i < portraitPaths.Count; i++)
                {
                    var path = portraitPaths[i];
                    var img = _imageService.LoadImage(path);
                    _imageList.Images.Add(img.Path, img.Image);
                    citizenPortraitListView.Items.Add(new ListViewItem(img.Path)
                    {
                        ImageIndex = i,
                        ForeColor = Color.WhiteSmoke
                    });
                    newPathList.Add(img.Path);
                }

                portraitPaths = newPathList;
                citizenPortraitListView.LargeImageList = _imageList;
            }
        }

        private void saveButtonClicked(object sender, EventArgs e)
        {
            OnSaved?.Invoke(portraitPaths);
            Close();
        }
    }
}
