namespace ModTools.Model.Events;

[Serializable]
public enum StatType
{
    PlanetClass,
    IsHomeworld,
    IsCapital,
    Credits,
    ProductionPoints,
    PreviousTurnProductionPoints,
    ManufacturingSlider,
    MilitarySlider,
    ResearchSlider,
    WealthSlider,
    Manufacturing,
    Military,
    Research,
    MaxManufacturing,
    Coercion,
    UncoercedProduction,
    SponsorDecay,
    IdeologyLiberty,
    IdeologyAuthority,
    IdeologyOpportunity,
    IdeologyEquality,
    IdeologyTradition,

    IdeologyInnovation,

    IdeologyCompassion,

    IdeologyCruelty,

    IdeologyTransparency,

    IdeologySecrecy,

    IdeologyDiversity,

    IdeologyHarmony,

    IdeologyFocus,

    IdeologyCalm,

    IdeologyPerTurnLiberty,

    IdeologyPerTurnAuthority,

    IdeologyPerTurnOpportunity,

    IdeologyPerTurnEquality,

    IdeologyPerTurnTradition,

    IdeologyPerTurnInnovation,

    IdeologyPerTurnCompassion,

    IdeologyPerTurnCruelty,

    IdeologyPerTurnTransparency,

    IdeologyPerTurnSecrecy,

    IdeologyPerTurnDiversity,

    IdeologyPerTurnHarmony,

    IdeologyPerTurnFocus,

    IdeologyPerTurnCalm,

    EmporiumFavor,

    NaturalLeagueFavor,

    WarforgedFavor,

    CulturePoints,

    CulturePerTurnBenevolent,

    CulturePerTurnNeutral,

    CulturePerTurnMerciless,

    Influence,

    InfluencePerTurn,

    PreviousTurnInfluence,

    InfluenceTally,

    Growth,

    GrowthYor,

    Tourism,

    FactionTourismRate,

    Food,

    FoodIncome,

    FoodCost,

    FoodNet,

    ColonyGrossIncome,

    ColonyTaxRevenue,

    ColonyNetIncome,

    ColonyPotentialMaxNetIncome,

    ColonySpending,

    CreditsSpending,

    CreditsPerTurn,

    GrossCreditsPerTurn,

    PreviousTurnApproval,

    Approval,

    RebellionPoints,

    RebellionPointsMax,

    GoodsAndServices,

    Population,

    PreviousTurnPopulation,

    PopulationCap,

    PopulationCapYor,

    EngineersAbility,

    UnrelentingAbility,

    AncientAbility,

    EntrepreneursAbility,

    PatrioticAbility,

    SyntheticLife,

    CanColonizeExtremeWorld,

    OperationsPoints,

    PlanetaryBombardment,

    PlanetaryDefense,

    ResistanceBonus,

    CanBeSurveyed,

    CanTourism,

    AssaultFighters,

    AssaultFightersCap,

    InterceptorFighters,

    InterceptorFightersCap,

    EscortFighters,

    EscortFightersCap,

    GuardianFighters,

    GuardianFightersCap,

    TradeLicensesMax,

    TradeLicensesUsed,

    GalacticTourismSpending,

    RaidIncome,

    TradeRouteIncome,

    WarResistance,

    WarEndurance,

    UseLocalSliders,

    Diplomacy,

    DiplomaticCapital,

    DiplomaticCapitalCost,

    DiplomaticCapitalIncome,

    DiplomacyBenevolent,

    DiplomacyNeutral,

    DiplomacyMerciless,

    DiplomacyTradeRouteWeight,

    DiplomacySharedBordersWeight,

    ImmuneToWar,

    ImmuneToCultureFlip,

    AngersOthersWhenWarVictimWeight,

    AlliesNeutralRaces,

    DiplomaticTradeOfferValueMult,

    DiplomaticTradeOfferValueMultMinors,

    Favored,

    Diversity,

    Urban,

    UnlimitedRange,

    Deception,

    Intimidation,

    Persuasion,

    LeaderMaxRecruits,

    LeaderCostModify,

    LeaderTraitChance,

    Elerium,

    Durantium,

    Antimatter,

    Promethion,

    Thulium,

    EleriumCost,

    DurantiumCost,

    AntimatterCost,

    PromethionCost,

    ThuliumCost,

    EleriumNet,

    DurantiumNet,

    AntimatterNet,

    PromethionNet,

    ThuliumNet,

    AscensionPoints,

    AscensionPointsPerTurn,

    TechVictoryPoints,

    ManufacturingOverflow,

    ResearchOverflow,

    HitPoints,

    HitPointsCap,

    StrategicRepair,

    TacticalRepair,

    DisableRepair,

    ExpPoints,

    ExpPointsCap,

    Mass,

    ArmorMass,

    ShieldMass,

    PointMass,

    BeamMass,

    MissileMass,

    KineticMass,

    ShipRangeMass,

    MovesCapMass,

    SensorRangeMass,

    SupportMass,

    MassCap,

    AOERange,

    Logistics,

    LogisticsCap,

    StationLogisticsCap,

    Administration,

    AdministrationUsage,

    AdministrationAwarded,

    Moves,

    MovesCap,

    TacticalSpeed,

    Acceleration,

    DefenseRange,

    InstantResearch,

    FactionPower,

    MilitaryPower,

    EconomicPower,

    InfluencePower,

    TechPower,

    Level,

    AdjacencyOnlyLevel,

    Crew,

    CreditValue,

    ManufacturingCost,

    ArmorManufacturingCost,

    ShieldManufacturingCost,

    PointManufacturingCost,

    BeamManufacturingCost,

    MissileManufacturingCost,

    KineticManufacturingCost,

    ShipRangeManufacturingCost,

    MovesCapManufacturingCost,

    SensorRangeManufacturingCost,

    Maintenance,

    ShipMaintenance,

    SalvageRatio,

    SensorRange,

    CanDetectCloak,

    CanCloak,

    CanSurvey,

    CanUpgrade,

    CanColonize,

    CanConstruct,

    CanCreateTradeRoute,

    CanInvade,

    CanSalvage,

    CanGenocidePlanet,

    IsImmuneToNebula,

    IsImmuneToRange,

    IsImmuneToInvasion0,

    IsImmuneToInvasion1,

    IsImmuneToInvasion2,

    IsImmuneToInvasion3,

    IsImmuneToInvasion4,

    IsImmuneToInvasion5,

    IsImmuneToInvasion6,

    IsImmuneToInvasion7,

    IsImmuneToInvasion8,

    IsImmuneToInvasion9,

    IsImmuneToInvasion10,

    IsImmuneToInvasion11,

    IsImmuneToInvasion12,

    IsImmuneToInvasion13,

    IsImmuneToInvasion14,

    IsImmuneToInvasion15,

    IsImmuneToInvasion16,

    IsImmuneToInvasion17,

    IsImmuneToInvasion18,

    IsImmuneToInvasion19,

    ShipRange,

    Accuracy,

    Jamming,

    BeamWeapon,

    KineticWeapon,

    MissileWeapon,

    ShieldDamageWeapon,

    ArmorDamageWeapon,

    PointDamageWeapon,

    ShieldEfficiency,

    ArmorEfficiency,

    PointEfficiency,

    WeaponsDisabled,

    BeamRange,

    KineticRange,

    MissileRange,

    BeamCooldown,

    KineticCooldown,

    MissileCooldown,

    BeamAccuracy,

    KineticAccuracy,

    MissileAccuracy,

    BeamAttack,

    KineticAttack,

    MissileAttack,

    IgnoreShield,

    IgnoreArmor,

    IgnorePoint,

    ShieldStrength,

    ArmorRating,

    PointDefense,

    Threat,

    Fortitude,

    Value,

    StarbaseRange,

    ModuleConstructionPoints,

    ModuleConstructionPointsCap,

    MoveCost,

    Mining,

    Soldiering,

    TradeRouteValueRaw,

    TradeRouteValue,

    RaidBonus,

    RaidValue,

    IsInitiator,

    ModifierValue,

    StarbaseMaintenance,

    DroneCount,

    RedundantAssemblyAbility,

    ScavengersAbility,

    ScavengersChance,

    ArchivistAbility,

    DamageReduction,

    BeamDamageReduction,

    KineticDamageReduction,

    MissileDamageReduction,

    IsImmuneToPirates,

    CanRespawnOnTradeRouteDeath,

    CanColonizeDeadWorld,

    MovesCapOverride,

    ShipRangeOverride,

    CanColonizeAquaticWorld,

    CanAssassinateDiplomats,

    SensorPower,

    AsteroidDecay,

    ExpValue,

    ExpBonus,

    EleriumIncome,

    DurantiumIncome,

    AntimatterIncome,

    PromethionIncome,

    ThuliumIncome,

    UltraSpice,

    UltraSpiceIncome,

    UltraSpiceCost,

    EpimetheusPollen,

    EpimetheusPollenIncome,

    EpimetheusPollenCost,

    HeliosOre,

    HeliosOreIncome,

    HeliosOreCost,

    ThuliumCatalyst,

    ThuliumCatalystIncome,

    ThuliumCatalystCost,

    TechapodHive,

    TechapodHiveIncome,

    TechapodHiveCost,

    ArtocarpusViriles,

    ArtocarpusVirilesIncome,

    ArtocarpusVirilesCost,

    MonsatiumDeposit,

    MonsatiumDepositIncome,

    MonsatiumDepositCost,

    CrystallizedElerium,

    CrystallizedEleriumIncome,

    CrystallizedEleriumCost,

    XanthiumDeposit,

    XanthiumDepositIncome,

    XanthiumDepositCost,

    AurorusArboretum,

    AurorusArboretumIncome,

    AurorusArboretumCost,

    PrometheusStone,

    PrometheusStoneIncome,

    PrometheusStoneCost,

    HyperSilicates,

    HyperSilicatesIncome,

    HyperSilicatesCost,

    PrecursorNanites,

    PrecursorNanitesIncome,

    PrecursorNanitesCost,

    HarmonyCrystals,

    HarmonyCrystalsIncome,

    HarmonyCrystalsCost,

    LabEquipment,

    LabEquipmentIncome,

    LabEquipmentCost,

    IndustrialScaffolding,

    IndustrialScaffoldingIncome,

    IndustrialScaffoldingCost,

    ArmoryModule,

    ArmoryModuleIncome,

    ArmoryModuleCost,

    CommercialGoods,

    CommercialGoodsIncome,

    CommercialGoodsCost,

    BroadcastEquipment,

    BroadcastEquipmentIncome,

    BroadcastEquipmentCost,

    Drones,

    DronesIncome,

    DronesCost,

    Modules,

    ModulesIncome,

    ModulesCost,

    Nanobots,

    NanobotsIncome,

    NanobotsCost,

    SnugglerColony,

    SnugglerColonyIncome,

    SnugglerColonyCost,

    AccumulatedUnitPoints,

    CitizenRate,

    TrainingRate,

    LegionsAvailable,

    StartingSoldierAmount,

    ResistanceToPlanetCapture,

    ApprovalFromSoldierUnits,

    ApprovalFromClericUnits,

    ApprovalFromScientistUnits,

    IgnoreRushLimit,

    RushCosts,

    UpgradeSlots,

    PointsPerAgent,

    SecurityLevel,

    ShipRangeUnderride,

    MovesCapUnderride,

    TriggerAndNoShipBattle,

    CanAttackAll,

    AirSuperiority,

    Garrisons,

    TaxationRate,

    RecentApprovalAverage,

    TourismTiles,

    CanBuildHypergate,

    CanSupplySocial,

    CanSupplyMilitary,

    WarProfitMult,

    BonusHPMaxInZOC,

    FoodBonus,

    PopulationTally,

    BaseMinerals,

    BaseTechnology,

    BaseWealth,

    BaseFertility,

    BasePlanetInfluence,

    Minerals,

    Technology,

    Wealth,

    Fertility,

    PlanetInfluence,

    MineralConversion,

    TechnologyConversion,

    WealthConversion,

    FertilityConversion,

    MineralNet,

    TechnologyNet,

    WealthNet,

    FertilityNet,

    PlanetInfluenceNet,

    ProtestingThreshold,

    PlanetTilesAvailable,

    BattleLength,

    SuicideAttackAbility,

    SuicideAttackBonus,

    EscapeAbility,

    EscapeChance,

    SurroundAbility,

    SwarmAbility,

    RetreatAbility,

    ColonySponsorDecayMod,

    Crime,

    Pollution,

    PollutionTally,

    PollutionPerTurn,

    Control,

    ControlTally,

    ControlPerTurn,

    UnitSpecializationCost,

    PolicyMaintenance,

    MaxEnactedPolicies,

    RandomTechSlots,

    CanBuildAsteroidMiningBase,

    ColonyApproval,

    ThinktankFavor,

    ThinktankFavorTally,

    Intelligence,

    Social,

    Diligence,

    Resolve,

    Expectations,

    Loyalty,

    PlanetaryDefensesHP,

    PlanetaryDefensesMaxHP,

    PlanetaryDefensesRepairAbility,

    TotalShipAttack,

    AdministratorCount,

    EngineerCount,

    ScientistCount,

    EntrepreneurCount,

    FarmerCount,

    EntertainerCount,

    SoldierCount,

    ClericCount,

    PrisonerCount,

    Prestige,

    BazaarDiscount,

    MemberCount
}