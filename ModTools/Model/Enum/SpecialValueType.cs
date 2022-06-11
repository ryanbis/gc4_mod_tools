namespace ModTools.Model.Events;

[Serializable]
public enum SpecialValueType
{
    PercentOfFactionCredits,
    PercentOfResearchCost,
    NumTurnsCultureBenevolent,
    NumTurnsCultureNeutral,
    NumTurnsCultureMerciless,
    GetValueFromStarbase,
    TradeRouteRaidBonus,
    ResearchTag,
    GameSpecified,
    GameSpecifiedNegative,
    Stat,
    Tech,
    Colonies,
    PercentRequiredToWin,
    MinDiplomaticRelationToSupport,
    MinDiplomaticRelationToGuaranteeSupport,
    HullMassScaleMod,
    StatCalc,
    StatCalcMult
}