using ModTools.Event;

namespace ModTools.View.Contracts;

public interface IOrbitBodyView : IView
{
    event EventHandler SaveClicked;
    event EventHandler<DataArg<string?>> BodyTypeSelected;
    
    DialogResult ShowOrbitLaneDialog(IEnumerable<string> bodyTypes);
    
    
    void Close();
    void ShowHomePlanetCheckbox(bool show);
    bool? GetIsHomePlanetChecked();
    string? GetBodyTypeSelected();

}