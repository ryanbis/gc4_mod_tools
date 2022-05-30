namespace ModTools.Model.Events;

[Serializable]
public enum TargetType
{
    Faction,
    Planet,
    Colony,
    Starbase,
    Shipyard,
    Ship,
    Fleet,
    AllShipsInFleet,
    Improvement,
    Tile,
    StrategicResource,
    StarbaseModule,
    TradeRoute,
    TradeRoutePath,
    Asteroid,
    Unit,
    Hyperlane,
    Hypergate,
    DeadPlanet,
    SecondaryPlayer,
    Policy,
    EnemyFleet,
    EmptyGalacticTile,
    Thinktank
}