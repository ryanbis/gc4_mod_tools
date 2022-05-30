using ModTools.Event;
using ModTools.Model.Space;
using ModTools.View.Contracts;

namespace ModTools.Presenter.Contracts;

public class OrbitBodyPresenter : IOrbitBodyPresenter
{
    public event IOrbitBodyPresenter.OnOrbitBodySaved? OrbitBodySaved;
    
    private readonly IOrbitBodyView _view;
    public IOrbitBodyView View => _view;

    private IEnumerable<string> BodyTypes;
    

    public OrbitBodyPresenter(IOrbitBodyView view)
    {
        _view = view;
        _view.SaveClicked += OnSaveClicked;
        _view.BodyTypeSelected += OnBodyTypeSelected;
    }

    private void OnBodyTypeSelected(object? sender, DataArg<string?> e)
    {
        var val = e.Value;
        var showHomeworld = val != null && val.Equals("Planet");
        _view.ShowHomePlanetCheckbox(showHomeworld);
    }

    private void OnSaveClicked(object? sender, EventArgs e)
    {
        var bodyType = _view.GetBodyTypeSelected();
        // TODO - Tell user why we're not saving here
        if (bodyType == null) return;
        var body = new OrbitBody();
        body.BodyType = bodyType;
        var homeworld = _view.GetIsHomePlanetChecked();
        if (homeworld != null)
        {
            body.IsHomeworld = homeworld.ToString().ToLower();
        }
        OrbitBodySaved?.Invoke(body);
        _view.Close();
    }

    public void Init(IEnumerable<string> data)
    {
        BodyTypes = data;
    }

    
    public void Show()
    {
        _view.ShowOrbitLaneDialog(BodyTypes);
    }
    
}