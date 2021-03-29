namespace NWN.Framework.Lite.Core.NWNX.Enum
{
    public enum FeedbackMessageTypes
    {
        // Feedback Message Types
        SkillCantUse = 0,
        SkillCantUseTimer = 1,
        SkillAnimalempathyValidTargets = 2,
        SkillTauntValidTargets = 3,
        SkillTauntTargetImmune = 223,
        SkillPickpocketStoleItem = 4,
        SkillPickpocketStoleGold = 5,
        SkillPickpocketAttemptingToSteal = 46,
        SkillPickpocketAttemptDetected = 150,
        SkillPickpocketStoleItemTarget = 47,
        SkillPickpocketStoleGoldTarget = 48,
        SkillPickpocketTargetBroke = 57,
        SkillHealTargetNotDispsnd = 55,
        SkillHealValidTargets = 56,
        SkillStealthInCombat = 60,

        /// Miscellaneous Targetting Messages
        TargetUnaware = 6,
        ActionNotPossibleStatus = 7,
        ActionNotPossiblePvp = 187,
        ActionCantReachTarget = 218,
        ActionNoLoot = 247,

        /// Miscellaneous Feedback Messages
        WeightTooEncumberedToRun = 8,
        WeightTooEncumberedWalkSlow = 9,
        WeightTooEncumberedCantPickup = 10,
        StatsLevelup = 11,
        InventoryFull = 12,
        ContainerFull = 212,
        TrapTriggered = 82,
        DamageHealed = 151,
        ExperienceGainned = 182,
        ExperienceLost = 183,
        Journalupdated = 184, // Doesn't actually work, use:

        // NWNX_Feedback_{Get/Set}JournalUpdatedMessageHidden()
        BarterCancelled = 185,

        /// Mode activation/deactivation Messages
        DetectModeActivated = 83,
        DetectModeDeactivated = 84,
        StealthModeActivated = 85,
        StealthModeDeactivated = 86,
        ParryModeActivated = 87,
        ParryModeDeactivated = 88,
        PowerAttackModeActivated = 89,
        PowerAttackModeDeactivated = 90,
        ImprovedPowerAttackModeActivated = 91,
        ImprovedPowerAttackModeDeactivated = 92,
        RapidShotModeActivated = 166,
        RapidShotModeDeactivated = 167,
        FlurryOfBlowsModeActivated = 168,
        FlurryOfBlowsModeDeactivated = 169,
        ExpertiseModeActivated = 227,
        ExpertiseModeDeactivated = 228,
        ImprovedExpertiseModeActivated = 229,
        ImprovedExpertiseModeDeactivated = 230,
        DefensiveCastModeActivated = 231,
        DefensiveCastModeDeactivated = 232,
        ModeCannotUseWeapons = 188,
        DirtyFightingModeActivated = 237,
        DirtyFightingModeDeactivated = 238,

        DefensiveStanceModeActivated = 252,
        DefensiveStanceModeDeactivated = 253,

        /// Equipping Feedback Messages
        EquipSkillSpellModifiers = 71,
        EquipUnidentified = 76,
        EquipMonkAbilities = 77,
        EquipInsufficientLevel = 98,
        EquipProficiencies = 119,
        EquipWeaponTooLarge = 120,
        EquipWeaponTooSmall = 260,
        EquipOneHandedWeapon = 121,
        EquipTwoHandedWeapon = 122,
        EquipWeaponSwappedOut = 123,
        EquipOneChainWeapon = 124,
        EquipNaturalAcNoStack = 189,
        EquipArmourAcNoStack = 190,
        EquipShieldAcNoStack = 191,
        EquipDeflectionAcNoStack = 192,
        EquipNoArmorCombat = 193,
        EquipRangerAbilities = 200,
        EquipAlignment = 207,
        EquipClass = 208,
        EquipRace = 209,
        UnequipNoArmorCombat = 194,

        /// Action Feedback Messages
        ObjectLocked = 13,
        ObjectNotLocked = 14,
        ObjectSpecialKey = 15,
        ObjectUsedKey = 16,
        RestExcitedCantRest = 17,
        RestBeginningRest = 18,
        RestFinishedRest = 19,
        RestCancelRest = 20,
        RestNotAllowedInArea = 54,
        RestNotAllowedByPossessedFamiliar = 153,
        RestNotAllowedEnemies = 186,
        RestCantUnderThisEffect = 213,
        CastLostTarget = 21,
        CastCantCast = 22,
        CastCntrspellTargetLostTarget = 52,
        CastArcaneSpellFailure = 61,
        CastCntrspellTargetArcaneSpellFailure = 118,
        CastEntangleConcentrationFailure = 65,
        CastCntrspellTargetEntangleConcentrationFailure = 147,
        CastSpellInterrupted = 72,
        CastEffectSpellFailure = 236,
        CastCantCastWhilePolymorphed = 107,
        CastUseHands = 210,
        CastUseMouth = 211,
        CastDefcastConcentrationFailure = 233,
        CastDefcastConcentrationSuccess = 240,
        UseitemCantUse = 23,
        ConversationToofar = 58,
        ConversationBusy = 59,
        ConversationInCombat = 152,
        CharacterIntransit = 74,
        CharacterOuttransit = 75,
        UseitemNotEquipped = 244,
        DropitemCantDrop = 245,
        DropitemCantGive = 246,
        ClientServerSpellMismatch = 259,

        /// Combat feedback messages
        CombatRunningOutOfAmmo = 24,
        CombatOutOfAmmo = 25,
        CombatHenchmanOutOfAmmo = 241,
        CombatDamageImmunity = 62,
        CombatSpellImmunity = 68,
        CombatDamageResistance = 63,
        CombatDamageResistanceRemaining = 66,
        CombatDamageReduction = 64,
        CombatDamageReductionRemaining = 67,
        CombatSpellLevelAbsorption = 69,
        CombatSpellLevelAbsorptionRemaining = 70,
        CombatWeaponNotEffective = 117,
        CombatEpicDodgeAttackEvaded = 234,
        CombatMassiveDamage = 235,
        CombatSavedVsMassiveDamage = 254,
        CombatSavedVsDevastatingCritical = 257,

        /// Feat Feedback Messages
        FeatSapValidTargets = 26,
        FeatKnockdownValidTargets = 27,
        FeatImpknockdownValidTargets = 28,
        FeatCalledShotNoLegs = 29,
        FeatCalledShotNoArms = 30,
        FeatSmiteGoodTargetNotGood = 239,
        FeatSmiteEvilTargetNotEvil = 53,
        FeatQuiveringPalmHigherLevel = 73,
        FeatKeenSenseDetect = 195,
        FeatUseUnarmed = 198,
        FeatUses = 199,
        FeatUseWeaponOfChoice = 243,

        /// Party Feedback Messages
        PartyNewLeader = 31,
        PartyMemberKicked = 32,
        PartyKickedYou = 33,
        PartyAlreadyConsidering = 34,
        PartyAlreadyInvolved = 35,
        PartySentInvitation = 36,
        PartyReceivedInvitation = 37,
        PartyJoined = 38,
        PartyInvitationIgnored = 39,
        PartyYouIgnoredInvitation = 40,
        PartyInvitationRejected = 41,
        PartyYouRejectedInvitation = 42,
        PartyInvitationExpired = 43,
        PartyLeftParty = 44,
        PartyYouLeft = 45,
        PartyHenchmanLimit = 49,
        PartyCannotLeaveTheOneParty = 196,
        PartyCannotKickFromTheOneParty = 197,
        PartyYouInvitedNonSingleton = 202,
        PvpReactionDislikesyou = 203,

        /// Item Feedback Messages
        ItemReceived = 50,
        ItemLost = 51,
        ItemEjected = 96,
        ItemUseUnidentified = 97,
        ItemGoldGained = 148,
        ItemGoldLost = 149,

        /// Spell Scroll Learning
        LearnScrollNotScroll = 78,
        LearnScrollCantLearnClass = 79,
        LearnScrollCantLearnLevel = 80,
        LearnScrollCantLearnAbility = 81,
        LearnScrollCantLearnOpposition = 219,
        LearnScrollCantLearnPossess = 220,
        LearnScrollCantLearnKnown = 221,
        LearnScrollCantLearnDivine = 224,
        LearnScrollSuccess = 222,

        /// Floaty text feedback
        FloatyTextStrref = 93,
        FloatyTextString = 94,

        /// Store feedback
        CannotSellPlotItem = 99,
        CannotSellContainer = 100,
        CannotSellItem = 101,
        NotEnoughGold = 102,
        TransactionSucceeded = 103,
        PriceTooHigh = 248,
        StoreNotEnoughGold = 249,
        CannotSellStolenItem = 250,
        CannotSellRestrictedItem = 251,

        /// Portal control feedback
        PortalTimedout = 104,
        PortalInvalid = 105,

        /// Chat feedback
        ChatTellPlayerNotFound = 106,

        /// Alignment Feedback
        AlignmentShift = 108,
        AlignmentPartyShift = 111,
        AlignmentChange = 109,
        AlignmentRestrictedByClassLost = 110,
        AlignmentRestrictedByClassGain = 115,
        AlignmentRestrictedWarningLoss = 116,
        AlignmentRestrictedWarningGain = 112,
        AlignmentEpitomeGained = 113,
        AlignmentEpitomeLost = 114,

        /// Immunity Feedback
        ImmunityDisease = 125,
        ImmunityCriticalHit = 126,
        ImmunityDeathMagic = 127,
        ImmunityFear = 128,
        ImmunityKnockdown = 129,
        ImmunityParalysis = 130,
        ImmunityNegativeLevel = 131,
        ImmunityMindSpells = 132,
        ImmunityPoison = 133,
        ImmunitySneakAttack = 134,
        ImmunitySleep = 135,
        ImmunityDaze = 136,
        ImmunityConfusion = 137,
        ImmunityStun = 138,
        ImmunityBlindness = 139,
        ImmunityDeafness = 140,
        ImmunityCurse = 141,
        ImmunityCharm = 142,
        ImmunityDominate = 143,
        ImmunityEntangle = 144,
        ImmunitySilence = 145,
        ImmunitySlow = 146,

        /// Associates
        AssociateSummoned = 154,
        AssociateUnsummoning = 155,
        AssociateUnsummoningBecauseRest = 156,
        AssociateUnsummoningBecauseDied = 157,
        AssociateDominated = 158,
        AssociateDominationEnded = 159,
        AssociatePossessedCannotRecoverTrap = 170,
        AssociatePossessedCannotBarter = 171,
        AssociatePossessedCannotEquip = 172,
        AssociatePossessedCannotRepositoryMove = 173,
        AssociatePossessedCannotPickUp = 174,
        AssociatePossessedCannotDrop = 175,
        AssociatePossessedCannotUnequip = 176,
        AssociatePossessedCannotRest = 177,
        AssociatePossessedCannotDialogue = 178,
        AssociatePossessedCannotGiveItem = 179,
        AssociatePossessedCannotTakeItem = 180,
        AssociatePossessedCannotUseContainer = 181,

        /// Miscellaneous Feedback
        ScriptError = 160,
        ActionListOverflow = 161,
        EffectListOverflow = 162,
        AiUpdateTimeOverflow = 163,
        ActionListWipeOverflow = 164,
        EffectListWipeOverflow = 165,
        SendMessageToPc = 204,
        SendMessageToPcStrref = 242,

        /// Misc GUI feedback
        GuiOnlyPartyLeaderMayClick = 201,
        Paused = 205,
        Unpaused = 206,
        RestYouMayNotAtThisTime = 214,
        GuiCharExportRequestSent = 215,
        GuiCharExportedSuccessfully = 216,
        GuiErrorCharNotExported = 217,
        CameraBg = 255,
        CameraEq = 256,
        CameraChasecam = 258,

        Saving = 225,
        SaveComplete = 226
    }
}