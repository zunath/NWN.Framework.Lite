namespace NWN.Framework.Lite.Enum
{
    public class EffectEngineType: NWEnumBase<int>
    {
        public static readonly EffectEngineType Invalid = new(0);
        public static readonly EffectEngineType Haste = new(1);
        public static readonly EffectEngineType DamageResistance = new(2);
        public static readonly EffectEngineType Slow = new(3);
        public static readonly EffectEngineType Resurrection = new(4);
        public static readonly EffectEngineType Disease = new(5);
        public static readonly EffectEngineType SummonCreature = new(6);
        public static readonly EffectEngineType Regenerate = new(7);
        public static readonly EffectEngineType SetState = new(8);
        public static readonly EffectEngineType SetStateInternal = new(9);
        public static readonly EffectEngineType AttackIncrease = new(10);
        public static readonly EffectEngineType AttackDecrease = new(11);
        public static readonly EffectEngineType DamageReduction = new(12);
        public static readonly EffectEngineType DamageIncrease = new(13);
        public static readonly EffectEngineType DamageDecrease = new(14);
        public static readonly EffectEngineType TemporaryHitpoints = new(15);
        public static readonly EffectEngineType DamageImmunityIncrease = new(16);
        public static readonly EffectEngineType DamageImmunityDecrease = new(17);
        public static readonly EffectEngineType Entangle = new(18);
        public static readonly EffectEngineType Death = new(19);
        public static readonly EffectEngineType Knockdown = new(20);
        public static readonly EffectEngineType Deaf = new(21);
        public static readonly EffectEngineType Immunity = new(22);
        public static readonly EffectEngineType SetAIState = new(23);
        public static readonly EffectEngineType EnemyAttackBonus = new(24);
        public static readonly EffectEngineType ArcaneSpellFailure = new(25);
        public static readonly EffectEngineType SavingThrowIncrease = new(26);
        public static readonly EffectEngineType SavingThrowDecrease = new(27);
        public static readonly EffectEngineType MovementSpeedIncrease = new(28);
        public static readonly EffectEngineType MovementSpeedDecrease = new(29);
        public static readonly EffectEngineType VisualEffect = new(30);
        public static readonly EffectEngineType AreaOfEffect = new(31);
        public static readonly EffectEngineType Beam = new(32);
        public static readonly EffectEngineType SpellResistanceIncrease = new(33);
        public static readonly EffectEngineType SpellResistanceDecrease = new(34);
        public static readonly EffectEngineType Poison = new(35);
        public static readonly EffectEngineType AbilityIncrease = new(36);
        public static readonly EffectEngineType AbilityDecrease = new(37);
        public static readonly EffectEngineType Damage = new(38);
        public static readonly EffectEngineType Heal = new(39);
        public static readonly EffectEngineType Link = new(40);
        public static readonly EffectEngineType HasteInternal = new(41);
        public static readonly EffectEngineType SlowInternal = new(42);
        public static readonly EffectEngineType ModifyNumAttacks = new(44);
        public static readonly EffectEngineType Curse = new(45);
        public static readonly EffectEngineType Silence = new(46);
        public static readonly EffectEngineType Invisibility = new(47);
        public static readonly EffectEngineType ACIncrease = new(48);
        public static readonly EffectEngineType ACDecrease = new(49);
        public static readonly EffectEngineType SpellImmunity = new(50);
        public static readonly EffectEngineType DispelAllMagic = new(51);
        public static readonly EffectEngineType DispelBestMagic = new(52);
        public static readonly EffectEngineType Taunt = new(53);
        public static readonly EffectEngineType Light = new(54);
        public static readonly EffectEngineType SkillIncrease = new(55);
        public static readonly EffectEngineType SkillDecrease = new(56);
        public static readonly EffectEngineType HitPointChangeWhenDying = new(57);
        public static readonly EffectEngineType SetWalkAnimation = new(58);
        public static readonly EffectEngineType LimitMovementSpeed = new(59);
        public static readonly EffectEngineType DamageShield = new(61);
        public static readonly EffectEngineType Polymorph = new(62);
        public static readonly EffectEngineType Sanctuary = new(63);
        public static readonly EffectEngineType Timestop = new(64);
        public static readonly EffectEngineType SpellLevelAbsorption = new(65);
        public static readonly EffectEngineType Icon = new(67);
        public static readonly EffectEngineType RacialType = new(68);
        public static readonly EffectEngineType Vision = new(69);
        public static readonly EffectEngineType SeeInvisible = new(70);
        public static readonly EffectEngineType Ultravision = new(71);
        public static readonly EffectEngineType Trueseeing = new(72);
        public static readonly EffectEngineType Blindness = new(73);
        public static readonly EffectEngineType Darkness = new(74);
        public static readonly EffectEngineType MissChance = new(75);
        public static readonly EffectEngineType Concealment = new(76);
        public static readonly EffectEngineType TurnResistanceIncrease = new(77);
        public static readonly EffectEngineType BonusSpellOfLevel = new(78);
        public static readonly EffectEngineType DisappearAppear = new(79);
        public static readonly EffectEngineType Disappear = new(80);
        public static readonly EffectEngineType Appear = new(81);
        public static readonly EffectEngineType NegativeLevel = new(82);
        public static readonly EffectEngineType BonusFeat = new(83);
        public static readonly EffectEngineType Wounding = new(84);
        public static readonly EffectEngineType Swarm = new(85);
        public static readonly EffectEngineType VampiricRegeneration = new(86);
        public static readonly EffectEngineType Disarm = new(87);
        public static readonly EffectEngineType TurnResistanceDecrease = new(88);
        public static readonly EffectEngineType BlindnessInactive = new(89);
        public static readonly EffectEngineType Petrify = new(90);
        public static readonly EffectEngineType ItemProperty = new(91);
        public static readonly EffectEngineType SpellFailure = new(92);
        public static readonly EffectEngineType CutsceneGhost = new(93);
        public static readonly EffectEngineType CutsceneImmobile = new(94);
        public static readonly EffectEngineType DefensiveStance = new(95);

        public EffectEngineType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator EffectEngineType(int internalValue) => new(internalValue);
    }
}