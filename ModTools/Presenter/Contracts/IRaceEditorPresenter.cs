using ModTools.View.Contracts;

namespace ModTools.Presenter.Contracts;

public interface IRaceEditorPresenter : IPresenter<IRaceEditorView>
{
    bool IsDestroyed { get; }
}