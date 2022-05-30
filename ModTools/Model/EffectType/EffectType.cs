namespace ModTools.Model.EffectType;

public sealed class EffectType
{
    public readonly string Name;
    public readonly string InternalName;
    public readonly string IconFile;

    private static readonly IList<EffectType> _values = new List<EffectType>();

    private EffectType(string name, string internalName, string iconFile)
    {
        Name = name;
        InternalName = internalName;
        IconFile = iconFile;
        _values.Add(this);
    }


    public static readonly EffectType Approval = 
        new EffectType(nameof(Approval), nameof(Approval), "GC3_Approval_Stat_Icon.png");
    
    public static readonly EffectType Diligence = 
        new EffectType(nameof(Diligence), nameof(Diligence), "LeaderStat_Diligence.png");
    
    public static readonly EffectType Expectations = 
        new EffectType(nameof(Expectations), nameof(Expectations), "LeaderStat_Expectations.png");
    
    public static readonly EffectType Food = 
        new EffectType(nameof(Food), "FoodCost", "GC3_Food_Stat_Icon.png");
    
    public static readonly EffectType Growth = 
        new EffectType(nameof(Growth), nameof(Growth), "GC3_Growth_Stat_Icon.png");
    
    public static readonly EffectType Intelligence = 
        new EffectType(nameof(Intelligence), nameof(Intelligence), "LeaderStat_Intelligence.png");
    
    public static readonly EffectType Resistance = 
        new EffectType(nameof(Resistance), "ResistanceBonus", "GC3_Resistance_Icon.png");
    
    public static readonly EffectType Resolve = 
        new EffectType(nameof(Resolve), nameof(Resolve), "Leaderstat_Resolve.png");
    
    public static readonly EffectType Social = 
        new EffectType(nameof(Social), nameof(Social), "LeaderStat_Social.png");
    
    public static readonly EffectType Soldiering = 
        new EffectType(nameof(Soldiering), nameof(Soldiering), "GC3_Soldiering_Icon.png");

    public static EffectType? FromInternalName(string internalName)
    {
        return _values.FirstOrDefault(val => val.InternalName.Equals(internalName));
    }
}