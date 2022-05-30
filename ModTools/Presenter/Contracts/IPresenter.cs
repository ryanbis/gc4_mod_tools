using ModTools.View.Contracts;

namespace ModTools.Presenter.Contracts;

public interface IPresenter<V> where V : IView
{
    public void Init();
    V View { get; }
    void Show();
}

public interface IPresenter<V, D> where V : IView
{
    public void Init(D data);
    V View { get; }
    void Show();
}
