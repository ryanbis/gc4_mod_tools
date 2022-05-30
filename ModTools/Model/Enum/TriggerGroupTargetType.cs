namespace ModTools.Model.Events;

[Serializable]
public enum TriggerGroupTargetType
{
    AllFactions,
    AllPlanets,
    AllColonies,
    AllStarbases,
    AllShipyards,
    AllShips,
    AllFleets,
    AllImprovements,
    AllStrategicResources,
    AllTradeRoutes,
    AllTradeRoutePaths,
    AllShipsInFleet,
    AllHypergates,
    AllHyperlanes,
    AllShipsInCluster,
    AllPlanetsInCluster,
    AllForeignTradeRouteColoines,
    AllLocalTradeRouteColoines,
    SpecificFaction
}