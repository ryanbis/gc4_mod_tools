using ModTools.Event;

namespace ModTools.View.Contracts;

public interface IManageCitizenPortraitsView : IView
{
    delegate void OnSave(IEnumerable<string> updatedPaths);

    event OnSave OnSaved;
    event EventHandler AddCitizenPortraitsClicked;
    event EventHandler<DataArg<IEnumerable<string>>> RemoveCitizenPortraitsClicked;
    
    void RefreshPaths(IEnumerable<string> citizenPortraitPaths);
}