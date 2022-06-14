namespace ModTools.Model.Events;

[Serializable]
public enum ActionType
{
    StatusEffect,

    RemoveStatusEffect,

    GiveObjectToTileOwner,

    KillPopulation,

    AwardModulePoints,

    AwardDominantIdeologyPoints,

    AwardFreeImprovement,

    AwardImprovement,

    AddUpgradeToPlanet,

    AddUpgradeToColony,

    AwardRandomShip,

    AwardPirateShipOfClass,

    AwardSpaceMonsterShipOfClass,

    AwardShipOfClass,

    AwardShipOfClassAtTile,

    AwardStartingShip,

    AwardShipOfClassToAllColonies,

    AwardColonyShipWithPassenger,

    CompletePercentOfCurrentTech,

    AwardCommander,

    FinishCurrentTech,

    FinishNearestPlanetProject,

    Wormhole,

    BattleEncounter,

    UPResolutionRedistributeWealth,

    UPResolutionRedistributeTech,

    UPResolutionCancelAllWars,

    UPResolutionCancelAllRebellion,

    UPResolutionDefiantRaceRemoval,

    UPResolutionCancelResearch,

    ChangePlanetTileToType,

    PlayerClaimAllPlanetsInRebellion,

    PlayerClaimAllStarbasesInRebellion,

    AwardResearchAmount,

    AwardSpecificTech,

    DisseminateUnlockedTechToAllMajorPlayers,

    TerraformTilesOnPlayerPlanets,

    TerraformTilesOnPlanet,

    DestroyTilesOnPlayerPlanets,

    DestroyTilesOnPlanet,

    DiscoverNearbyPlanetOfClass,

    FlipForeignPlanet,

    FlipPlanetToForeignInfluence,

    SpawnPlanetNearOtherFaction,

    SpawnPlanetNearUs,

    SpawnPlanetFarFromUs,

    DeclarationOfWarByNeutralPlayers,

    DoActionPlayerCancelAllRebellion,

    PlayerChangeTradeRouteType,

    DestroyObject,

    PlaceWaypoint,

    EnableObjective,

    CompleteObjective,

    EnableScenarioTrigger,

    DoScenarioConversation,

    DisableUIControl,

    UnhideUIControl,

    DestroyObjectByCampaignID,

    DestroyObjectsByFlags,

    PlaceAnomaly,

    TriggerGlobalEvent,

    TriggerMegaEvent,

    DisableMegaEvent,

    TriggerColonizationEvent,

    ShowStartingPositions,

    SpawnFaction,

    SpawnPirates,

    SpawnArtifact,

    AwardArtifactToWeakestPlayer,

    AwardArtifactToStrongestPlayer,

    SpawnAnomaly,

    ConvertDeadPlanet,

    ConvertDeadPlanetToThulium,

    ConvertAsteroidsToDurantium,

    ConvertGasGiantToPromethion,

    SpawnElerium,

    SpawnAntimatter,

    SpawnRelic,

    SpawnEleriumProportional,

    SpawnAntimatterProportional,

    SpawnRelicProportional,

    Assassination,

    GrantRandomTech,

    GrantRandomTechToAll,

    ConvertDeadPlanetProportional,

    ConvertDeadPlanetToThuliumProportional,

    ConvertAsteroidsToDurantiumProportional,

    ConvertGasGiantToPromethionProportional,

    FlipNonCapitalPlanetInAreaEffect,

    UnhideScreen,

    AwardMercenaryShip,

    AwardRandomMercenaryShip,

    ChangePlayerRelations,

    RemoveEventChoice,

    StoreEventChoice,

    StoreEventTarget,

    StoreQuestTarget,

    RemoveStoredEventTargets,

    StatCheck,

    AwardExistingPlanetToPlayer,

    SpawnCampaignPlanetForPlayer,

    OverrideAICaution,

    OverrideAITargetValue,

    AwardResource,

    AwardSpecificResource,

    MineSurroundingResources,

    AwardResourceForEachColonyInRange,

    GiveExhortGovernorCreditReward,

    GrantUnitType,

    GrantUnitTypeAndPlace,

    KillUnitSelf,

    ChangeUnitType,

    CheckAgentProtection,

    RecallUnit,

    IncreaseUnitLevel,

    UnitStealTech,

    UnitDestroyTile,

    ReturnLeaderToPool,

    ImproveLeaderStat,

    AddTraitToLeader,

    AddTraitToSovereign,

    RemoveTraitFromLeader,

    FinishShipyardProject,

    ChangeShip,

    RepairShip,

    ResetMoves,

    GenericConversation,

    ChangeShipToBestPirateShip,

    ConvertFleetToFaction,

    DestroyFleets,

    CreateUnitOnPlanet,

    CreateAndSendShipMission,

    AwardInfluence,

    SpawnShipNearPlayer,

    SpawnPirateShipNearPlayer,

    SpawnPirateShipAtTile,

    KillPlanet,

    KillAllUnitsOnPlanet,

    RecallAllUnitsOnPlanet,

    GiveTraitToAllUnitsOnPlanet,

    RemoveTraitFromAllUnitsOnPlanet,

    GiveTraitToAllLeaders,

    SpawnPirateStarbaseNearPlayer,

    SpawnStarbaseNearPlayer,

    SpawnShipyardAtTile,

    SpawnShipyardsAroundGalaxy,

    SpawnEncountersAroundShipyards,

    UnlockAchievement,

    GiveArtifactPower,

    ShowAreaForTurns,

    ConvertDeadWorld,

    PlayEffectOnTile,

    SetFlag,

    ClearFlag,

    ModifyCounter,

    SetCounter,

    ClearCounter,

    TriggerForcedPlayerEvent,

    TriggerAnomalyEvent,

    TriggerCapsuleEvent,

    TriggerArtifactEvent,

    TriggerGraveyardEvent,

    TriggerPrecursorEvent,

    ChangeCitizenSpecialization,

    ApplyGenericDiplomaticMod,

    SetDiplomaticRelationWithMinor,

    SelectTradeAgreementWithMinor,

    AllyWithSpecificFaction,

    SetEverwarCounter,

    SetDogpileCounter,

    StartApocalypse,

    GiveWeakestPlayerPlanetUpgrade,

    AwardPrestigePerInfluence,

    AwardPrestigePerMilitaryPower,

    UpdateTechTreeUI,

    BeginTrackingQuest,

    UpdateQuestDisplayStatus,

    ActivateQuestObjective,

    RecallAllDiplomats,

    TryConvertCitizen,

    ConsumeCitizen,

    TrySpreadCitizenTrait,

    AddNewLeaderOptions,

    RevealDetectedObjects,

    UpdateCameraZoomLimits,

    InitiateGovernmentUpgradeElectionCountdown,

    TryUpgradePlayerGovernment,

    UpgradePlayerGovernment,

    DowngradePlayerGovernment,

    SelectMinorCivTreaty,

    AdjustThinktankFavor
}