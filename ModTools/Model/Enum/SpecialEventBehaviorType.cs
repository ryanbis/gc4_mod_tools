namespace ModTools.Model.Events;

[Serializable]
public enum SpecialEventBehaviorType
{
    ActOnRandomFactionPlanet,
    ActOnRandomNonHomeworldPlanet,
    RandomPlayerContext,
    SpecificFactionContext,
    ActOnRandomCoreWorld,
    ActOnRandomColony
}