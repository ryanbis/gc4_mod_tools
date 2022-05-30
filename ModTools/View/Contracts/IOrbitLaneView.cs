using ModTools.Event;
using ModTools.Model.Space;

namespace ModTools.View.Contracts;

public interface IOrbitLaneView : IView
{
    event EventHandler SaveClicked;
    event EventHandler<DataArg<string?>> LaneTypeSelected; 

    DialogResult ShowOrbitLaneDialog(IEnumerable<string> laneTypes);

    void ShowMinMaxPlanets(bool show);
    void Close();
    string? GetLaneType();
    int? GetMinPlanets();
    int? GetMaxPlanets();
}