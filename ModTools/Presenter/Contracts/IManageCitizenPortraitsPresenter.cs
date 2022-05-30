using ModTools.Event;
using ModTools.View.Contracts;

namespace ModTools.Presenter.Contracts;

public interface IManageCitizenPortraitsPresenter : IPresenter<IManageCitizenPortraitsView>
{
    event EventHandler<DataArg<IEnumerable<string>>> OnSaveCitizenImages;
    void RefreshPaths(IEnumerable<string> imagePaths);
}