using ModTools.View.Contracts;

namespace ModTools.Presenter.Contracts;

public interface IMainMenuPresenter : IPresenter<IMainMenuView>
{
    Form Form();
    void Init();
}