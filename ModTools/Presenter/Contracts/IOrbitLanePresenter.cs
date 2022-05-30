using ModTools.Event;
using ModTools.Model.Space;
using ModTools.View.Contracts;

namespace ModTools.Presenter.Contracts;

public interface IOrbitLanePresenter : IPresenter<IOrbitLaneView, IOrbitLanePresenter.OrbitConfig>
{
    event OrbitLaneSaved OrbitLaneSavedEvent;
    
    public delegate void OrbitLaneSaved(OrbitLane lane);
    
    
    public class OrbitConfig
    {
        public IEnumerable<string> laneTypes;
    }
}