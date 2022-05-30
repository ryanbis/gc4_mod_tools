using Microsoft.Extensions.DependencyInjection;
using ModTools.Event;
using ModTools.Presenter.Contracts;
using ModTools.View.Contracts;

namespace ModTools.Presenter;

public class ManageCitizenPortraitsPresenter : IManageCitizenPortraitsPresenter
{
    private readonly IServiceProvider _serviceProvider;
    
    private readonly IManageCitizenPortraitsView _view;
    public IManageCitizenPortraitsView View => _view;

    public event EventHandler<DataArg<IEnumerable<string>>>? OnSaveCitizenImages;
    
    private Dictionary<string, string> portraitMap { get; } = new();
    
    
    public ManageCitizenPortraitsPresenter(IManageCitizenPortraitsView view, IServiceProvider serviceProvider)
    {
        _view = view;
        _serviceProvider = serviceProvider;
    }
    
    public void Init()
    {
        _view.OnSaved += OnSaved;
        _view.AddCitizenPortraitsClicked += OnAddCitizenPortraitsClicked;
        _view.RemoveCitizenPortraitsClicked += OnRemoveCitizenPortraitsClicked;
    }
    
    public void RefreshPaths(IEnumerable<string> imagePaths)
    {
        portraitMap.Clear();
        foreach (var imagePath in imagePaths)
        {
            portraitMap.Add(Path.GetFileName(imagePath), imagePath);
        }
        _view.RefreshPaths(imagePaths);
    }
    
    private void OnRemoveCitizenPortraitsClicked(object? sender, DataArg<IEnumerable<string>> e)
    {
        // TODO - Implement confirmation dialog
        foreach (var path in e.Value)
        {
            portraitMap.Remove(Path.GetFileName(path));
        }
        _view.RefreshPaths(portraitMap.Values);
    }

    private void OnAddCitizenPortraitsClicked(object? sender, EventArgs e)
    {
        var filedialog = _serviceProvider.GetRequiredService<IRequestImageFileView>();
        var result = filedialog.RequestImageFile(true);
        if (result.Canceled)
        {
            return;
        }

        foreach (var path in result.Paths)
        {
            portraitMap.Add(Path.GetFileName(path), path);
        }
        _view.RefreshPaths(portraitMap.Values);
    }

    private void OnSaved(IEnumerable<string> updatedpaths)
    {
        OnSaveCitizenImages?.Invoke(null, new DataArg<IEnumerable<string>>(updatedpaths));
    }

    public void Show()
    {
        _view.ShowDialog();
    }
}