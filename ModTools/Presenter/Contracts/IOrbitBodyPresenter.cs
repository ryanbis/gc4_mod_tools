using ModTools.Model.Space;
using ModTools.View.Contracts;

namespace ModTools.Presenter.Contracts;

public interface IOrbitBodyPresenter : IPresenter<IOrbitBodyView, IEnumerable<string>>
{
    event OnOrbitBodySaved OrbitBodySaved;
    
    public delegate void OnOrbitBodySaved(OrbitBody body);
}