namespace ModTools.Model.Events;

[Serializable]
public enum OnEventType
{
    OnConstructShip,

    OnConstructImprovment,

    OnImprovementPlacedOnStartup,

    OnPlanetTileOwnerChangeToForeign,

    OnPlanetTileOwnerChangeToSelf,

    OnGenocidePlanet,

    OnCollideAtAnomaly,

    OnArriveAtAnomaly,

    OnEventChoice,

    OnUPResolutionPassed,

    OnCultureTraitUnlock,

    OnColonizePlanet,

    OnConquerPlanet,

    OnConquerPlanetFirstTime,

    OnPlanetRebellionComplete,

    OnHomeworldConquered,

    OnConversationResponse,

    OnTechResearched,

    OnStartTurn,

    OnObjectDestroyed,

    OnConstructShipyard,

    OnConstructStarbase,

    OnPlayerDead,

    OnTechAgeReached,

    OnCollideWithCampaignWaypoint,

    OnScreenUnhidden,

    OnInitialShips,

    OnStartMegaEvent,

    OnTurnCountSinceTrigger,

    OnFinishBattleVictory,

    OnCreateTradeRoute,

    OnConstructModule,

    OnMeetMercenary,

    OnUnhideObject,

    OnRelationsStateChange,

    OnPlanetFlippedFromCulture,

    OnRelationsRequirementMet,

    OnUnitGenerated,

    OnUnitDestinationReached,

    OnStartNormalTurn,

    OnShipTriggersNoBattle,

    OnShipMissionComplete,

    OnGovernmentChanged,

    OnArtifactPowerUsed,

    OnSupplyReachedColony,

    OnWinFleetBattle,

    OnDefendedFleetBattle,

    OnPlayerSetup,

    OnPostMapGenSetup,

    OnBattleSetup,

    OnAssassinateDiplomat,

    OnRecruitLeader,

    OnEnactPolicy,

    OnRepealPolicy,

    OnEnforceLaw,

    OnSeizeGoods,

    OnQuellProtest,

    OnFestival,

    OnAddLevelUpgradeToShip,

    OnCreatePlanet,

    OnUpgradeGovernmentSucceeded,

    OnUpgradeGovernmentFailed,

    OnObjectAbilityUsed,

    OnLeaderActionUsed,

    OnMinisterAssigned,

    OnMinisterUnassigned,

    OnCommandShipCreated,

    OnGovernorFired,

    OnGovernorExecuted
}