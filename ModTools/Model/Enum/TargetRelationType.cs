namespace ModTools.Model.Events;

[Serializable]
public enum TargetRelationType
{
    Self,
    Friendly,
    Foreign,
    Enemy,
    Trading,
    Any
}