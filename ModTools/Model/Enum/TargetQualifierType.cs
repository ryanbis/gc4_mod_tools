namespace ModTools.Model.Events;

[Serializable]
public enum TargetQualifierType
{
    TradingWithAllUPMembersNotAtWar,
    IsAncient,
    NotPatriotic,
    EitherPartnerIsEntrepreneur,
    IsStationed,
    IsDistrict,
    CoreWorldsOnly,
    ColonyWorldsOnly,
    CapitalWorldOnly,
    NonCapitalWorldsOnly,
    SameSpeciesAsPlayer,
    DifferentSpeciesAsPlayer,
    GovernorOnly,
    GovernorOnlyNotSovereign,
    InOwnersZOC
}