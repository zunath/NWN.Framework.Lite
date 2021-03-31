namespace NWN.Framework.Lite.Enum
{
    public class EffectScriptType: NWEnumBase<int>
    {
        public static readonly EffectScriptType Invalideffect = new(0);
        public static readonly EffectScriptType DamageResistance = new(1);

        //      AbilityBonus                = 2,
        public static readonly EffectScriptType Regenerate = new(3);

        //      SavingThrowBonus            = 4,
        //      ModifyAc                    = 5,
        //      AttackBonus                 = 6,
        public static readonly EffectScriptType DamageReduction = new(7);

        //      DamageBonus                 = 8,
        public static readonly EffectScriptType TemporaryHitpoints = new(9);

        //      DamageImmunity              = 10,
        public static readonly EffectScriptType Entangle = new(11);
        public static readonly EffectScriptType Invulnerable = new(12);
        public static readonly EffectScriptType Deaf = new(13);
        public static readonly EffectScriptType Resurrection = new(14);
        public static readonly EffectScriptType Immunity = new(15);

        //      Blind                       = 16,
        public static readonly EffectScriptType EnemyAttackBonus = new(17);
        public static readonly EffectScriptType ArcaneSpellFailure = new(18);

        //      MovementSpeed               = 19,
        public static readonly EffectScriptType AreaOfEffect = new(20);
        public static readonly EffectScriptType Beam = new(21);

        //      SpellResistance             = 22,
        public static readonly EffectScriptType Charmed = new(23);
        public static readonly EffectScriptType Confused = new(24);
        public static readonly EffectScriptType Frightened = new(25);
        public static readonly EffectScriptType Dominated = new(26);
        public static readonly EffectScriptType Paralyze = new(27);
        public static readonly EffectScriptType Dazed = new(28);
        public static readonly EffectScriptType Stunned = new(29);
        public static readonly EffectScriptType Sleep = new(30);
        public static readonly EffectScriptType Poison = new(31);
        public static readonly EffectScriptType Disease = new(32);
        public static readonly EffectScriptType Curse = new(33);
        public static readonly EffectScriptType Silence = new(34);
        public static readonly EffectScriptType Turned = new(35);
        public static readonly EffectScriptType Haste = new(36);
        public static readonly EffectScriptType Slow = new(37);
        public static readonly EffectScriptType AbilityIncrease = new(38);
        public static readonly EffectScriptType AbilityDecrease = new(39);
        public static readonly EffectScriptType AttackIncrease = new(40);
        public static readonly EffectScriptType AttackDecrease = new(41);
        public static readonly EffectScriptType DamageIncrease = new(42);
        public static readonly EffectScriptType DamageDecrease = new(43);
        public static readonly EffectScriptType DamageImmunityIncrease = new(44);
        public static readonly EffectScriptType DamageImmunityDecrease = new(45);
        public static readonly EffectScriptType ACIncrease = new(46);
        public static readonly EffectScriptType ACDecrease = new(47);
        public static readonly EffectScriptType MovementSpeedIncrease = new(48);
        public static readonly EffectScriptType MovementSpeedDecrease = new(49);
        public static readonly EffectScriptType SavingThrowIncrease = new(50);
        public static readonly EffectScriptType SavingThrowDecrease = new(51);
        public static readonly EffectScriptType SpellResistanceIncrease = new(52);
        public static readonly EffectScriptType SpellResistanceDecrease = new(53);
        public static readonly EffectScriptType SkillIncrease = new(54);
        public static readonly EffectScriptType SkillDecrease = new(55);
        public static readonly EffectScriptType Invisibility = new(56);
        public static readonly EffectScriptType ImprovedInvisibility = new(57);
        public static readonly EffectScriptType Darkness = new(58);
        public static readonly EffectScriptType DispelMagicAll = new(59);
        public static readonly EffectScriptType ElementalShield = new(60);
        public static readonly EffectScriptType NegativeLevel = new(61);
        public static readonly EffectScriptType Polymorph = new(62);
        public static readonly EffectScriptType Sanctuary = new(63);
        public static readonly EffectScriptType TrueSeeing = new(64);
        public static readonly EffectScriptType SeeInvisible = new(65);
        public static readonly EffectScriptType Timestop = new(66);
        public static readonly EffectScriptType Blindness = new(67);
        public static readonly EffectScriptType SpellLevelAbsorption = new(68);
        public static readonly EffectScriptType DispelMagicBest = new(69);
        public static readonly EffectScriptType Ultravision = new(70);
        public static readonly EffectScriptType MissChance = new(71);
        public static readonly EffectScriptType Concealment = new(72);
        public static readonly EffectScriptType SpellImmunity = new(73);
        public static readonly EffectScriptType Visualeffect = new(74);
        public static readonly EffectScriptType DisappearAppear = new(75);
        public static readonly EffectScriptType Swarm = new(76);
        public static readonly EffectScriptType TurnResistanceDecrease = new(77);
        public static readonly EffectScriptType TurnResistanceIncrease = new(78);
        public static readonly EffectScriptType Petrify = new(79);
        public static readonly EffectScriptType CutsceneParalyze = new(80);
        public static readonly EffectScriptType Ethereal = new(81);
        public static readonly EffectScriptType SpellFailure = new(82);
        public static readonly EffectScriptType CutsceneGhost = new(83);
        public static readonly EffectScriptType CutsceneImmobilize = new(84);

        public EffectScriptType(int internalValue) : base(internalValue)
        {
        }
    }
}