namespace ModTools.Model.Events;

[Serializable]
public enum EvaluationType
{
    LessThan,
    GreaterThan,
    Equals,
    LessThanOrEqual,
    GreaterThanOrEqual,
    Range
}