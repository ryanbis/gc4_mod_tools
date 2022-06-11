namespace ModTools.Model.Race;

public class GameUsedProperties
{
    public IEnumerable<string>? TargetTypes { get; set; }
    public IEnumerable<string>? BonusTypes { get; set; }
    public IEnumerable<string>? EffectTypes { get; set; }
    public IEnumerable<SpecialValue> SpecialValues { get; set; }
    public IEnumerable<string>? ApprovalTypes { get; set; }
    public IEnumerable<string>? ApprovalTags { get; set; }
    public IEnumerable<string>? DefaultTraits { get; set; }
    public IEnumerable<string>? ConsumedTraits { get; set; }
}