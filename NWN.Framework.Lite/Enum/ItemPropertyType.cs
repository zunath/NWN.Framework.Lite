namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyType: NWEnumBase<int>
    {
        public static readonly ItemPropertyType Invalid = new(-1);
        public static readonly ItemPropertyType AbilityBonus = new(0);
        public static readonly ItemPropertyType ACBonus = new(1);
        public static readonly ItemPropertyType ACBonusVsAlignmentGroup = new(2);
        public static readonly ItemPropertyType ACBonusVsDamageType = new(3);
        public static readonly ItemPropertyType ACBonusVsRacialGroup = new(4);
        public static readonly ItemPropertyType ACBonusVsSpecificAlignment = new(5);
        public static readonly ItemPropertyType EnhancementBonus = new(6);
        public static readonly ItemPropertyType EnhancementBonusVsAlignmentGroup = new(7);
        public static readonly ItemPropertyType EnhancementBonusVsRacialGroup = new(8);
        public static readonly ItemPropertyType EnhancementBonusVsSpecificAlignement = new(9);
        public static readonly ItemPropertyType DecreasedEnhancementModifier = new(10);
        public static readonly ItemPropertyType BaseItemWeightReduction = new(11);
        public static readonly ItemPropertyType BonusFeat = new(12);
        public static readonly ItemPropertyType BonusSpellSlotOfLevelN = new(13);
        public static readonly ItemPropertyType CastSpell = new(15);
        public static readonly ItemPropertyType DamageBonus = new(16);
        public static readonly ItemPropertyType DamageBonusVsAlignmentGroup = new(17);
        public static readonly ItemPropertyType DamageBonusVsRacialGroup = new(18);
        public static readonly ItemPropertyType DamageBonusVsSpecificAlignment = new(19);
        public static readonly ItemPropertyType ImmunityDamageType = new(20);
        public static readonly ItemPropertyType DecreasedDamage = new(21);
        public static readonly ItemPropertyType DamageReduction = new(22);
        public static readonly ItemPropertyType DamageResistance = new(23);
        public static readonly ItemPropertyType DamageVulnerability = new(24);
        public static readonly ItemPropertyType Darkvision = new(26);
        public static readonly ItemPropertyType DecreasedAbilityScore = new(27);
        public static readonly ItemPropertyType DecreasedAC = new(28);
        public static readonly ItemPropertyType DecreasedSkillModifier = new(29);
        public static readonly ItemPropertyType EnhancedContainerReducedWeight = new(32);
        public static readonly ItemPropertyType ExtraMeleeDamageType = new(33);
        public static readonly ItemPropertyType ExtraRangedDamageType = new(34);
        public static readonly ItemPropertyType Haste = new(35);
        public static readonly ItemPropertyType HolyAvenger = new(36);
        public static readonly ItemPropertyType ImmunityMiscellaneous = new(37);
        public static readonly ItemPropertyType ImprovedEvasion = new(38);
        public static readonly ItemPropertyType SpellResistance = new(39);
        public static readonly ItemPropertyType SavingThrowBonus = new(40);
        public static readonly ItemPropertyType SavingThrowBonusSpecific = new(41);
        public static readonly ItemPropertyType Keen = new(43);
        public static readonly ItemPropertyType Light = new(44);
        public static readonly ItemPropertyType Mighty = new(45);
        public static readonly ItemPropertyType MindBlank = new(46);
        public static readonly ItemPropertyType NoDamage = new(47);
        public static readonly ItemPropertyType OnHitProperties = new(48);
        public static readonly ItemPropertyType DecreasedSavingThrows = new(49);
        public static readonly ItemPropertyType DecreasedSavingThrowsSpecific = new(50);
        public static readonly ItemPropertyType Regeneration = new(51);
        public static readonly ItemPropertyType SkillBonus = new(52);
        public static readonly ItemPropertyType ImmunitySpecificSpell = new(53);
        public static readonly ItemPropertyType ImmunitySpellSchool = new(54);
        public static readonly ItemPropertyType ThievesTools = new(55);
        public static readonly ItemPropertyType AttackBonus = new(56);
        public static readonly ItemPropertyType AttackBonusVsAlignmentGroup = new(57);
        public static readonly ItemPropertyType AttackBonusVsRacialGroup = new(58);
        public static readonly ItemPropertyType AttackBonusVsSpecificAlignment = new(59);
        public static readonly ItemPropertyType DecreasedAttackModifier = new(60);
        public static readonly ItemPropertyType UnlimitedAmmunition = new(61);
        public static readonly ItemPropertyType UseLimitationAlignmentGroup = new(62);
        public static readonly ItemPropertyType UseLimitationClass = new(63);
        public static readonly ItemPropertyType UseLimitationRacialType = new(64);
        public static readonly ItemPropertyType UseLimitationSpecificAlignment = new(65);
        public static readonly ItemPropertyType UseLimitationTileset = new(66);
        public static readonly ItemPropertyType RegenerationVampiric = new(67);
        public static readonly ItemPropertyType Trap = new(70);
        public static readonly ItemPropertyType TrueSeeing = new(71);
        public static readonly ItemPropertyType OnMonsterHit = new(72);
        public static readonly ItemPropertyType TurnResistance = new(73);
        public static readonly ItemPropertyType MassiveCriticals = new(74);
        public static readonly ItemPropertyType FreedomOfMovement = new(75);
        public static readonly ItemPropertyType Poison = new(76); // no longer working, poison is now a onHit  subtype
        public static readonly ItemPropertyType MonsterDamage = new(77);
        public static readonly ItemPropertyType ImmunitySpellsByLevel = new(78);
        public static readonly ItemPropertyType SpecialWalk = new(79);
        public static readonly ItemPropertyType HealersKit = new(80);
        public static readonly ItemPropertyType WeightIncrease = new(81);
        public static readonly ItemPropertyType OnHitCastSpell = new(82);
        public static readonly ItemPropertyType Visualeffect = new(83);
        public static readonly ItemPropertyType ArcaneSpellFailure = new(84);
        public static readonly ItemPropertyType Material = new(85);
        public static readonly ItemPropertyType Quality = new(86);
        public static readonly ItemPropertyType Additional = new(87);

        public ItemPropertyType(int internalValue) : base(internalValue)
        {
        }
    }
}