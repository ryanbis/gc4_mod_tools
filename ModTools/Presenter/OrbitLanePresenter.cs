using ModTools.Event;
using ModTools.Model.Space;
using ModTools.Presenter.Contracts;
using ModTools.View.Contracts;

namespace ModTools.Presenter;

public class OrbitLanePresenter : IOrbitLanePresenter
{
    private readonly IOrbitLaneView _view;
    public IOrbitLaneView View => _view;
    
    private IEnumerable<string>? LaneTypes;
    
    public event IOrbitLanePresenter.OrbitLaneSaved? OrbitLaneSavedEvent;


    public OrbitLanePresenter(IOrbitLaneView view)
    {
        _view = view;
    }
    
    
    public void Init(IOrbitLanePresenter.OrbitConfig data)
    {
        LaneTypes = data.laneTypes;
        _view.SaveClicked += OnSaveClicked;
        _view.LaneTypeSelected += OnLaneTypeSelected;
    }

    private void OnLaneTypeSelected(object? sender, DataArg<string?> e)
    {
        var isStar = e.Value != null && e.Value.Equals("Star");
        _view.ShowMinMaxPlanets(!isStar);
    }

    private void OnSaveClicked(object? sender, EventArgs e)
    {
        // Do the save here
        var laneType = _view.GetLaneType();
        if (laneType == null) return;
        var lane = new OrbitLane
        {
            LaneType = laneType
        };
        var min = _view.GetMinPlanets();
        if (min != null)
        {
            lane.MinPlanets = min.Value.ToString();
        }
        var max = _view.GetMaxPlanets();
        if (max != null)
        {
            lane.MaxPlanets = max.Value.ToString();
        }

        _view.Close();
        OrbitLaneSavedEvent?.Invoke(lane);
    }

    public void Show()
    {
        _view.ShowOrbitLaneDialog(LaneTypes);
    }
    
}