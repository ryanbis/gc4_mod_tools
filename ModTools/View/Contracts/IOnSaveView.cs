using ModTools.Presenter;

namespace ModTools.View.Contracts;

public interface IOnSaveView<T> : IView
{
    public delegate void OnSave(T data);
}