using ModTools.Model.Events;
using ModTools.Presenter.Contracts;
using ModTools.View.Contracts;

namespace ModTools.Presenter;

public class EventEditorPresenter : IEventEditorPresenter
{

    private readonly IEventEditorView _view;
    public IEventEditorView View => _view;

    public EventEditorPresenter(IEventEditorView view)
    {
        _view = view;
    }
    
    public void Init()
    {
        _view.SetCulturalAlignmentTypes(Enum.GetNames(typeof(CulturalAlignmentType)));
        _view.SetEventTypes(Enum.GetNames(typeof(EventType)));
    }

    
    public void Show()
    {
        _view.Show();
    }
}