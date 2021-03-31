namespace NWN.Framework.Lite.Enum
{
    public class AreaOfEffectType: NWEnumBase<int>
    {
        public static readonly AreaOfEffectType FogAcid = new(0);
        public static readonly AreaOfEffectType FogFire = new(1);
        public static readonly AreaOfEffectType FogStink = new(2);
        public static readonly AreaOfEffectType FogKill = new(3);
        public static readonly AreaOfEffectType FogMind = new(4);
        public static readonly AreaOfEffectType WallFire = new(5);
        public static readonly AreaOfEffectType WallWind = new(6);
        public static readonly AreaOfEffectType WallBlade = new(7);
        public static readonly AreaOfEffectType Web = new(8);
        public static readonly AreaOfEffectType Entangle = new(9);
        public static readonly AreaOfEffectType Chaos = new(10);
        public static readonly AreaOfEffectType Darkness = new(11);
        public static readonly AreaOfEffectType CircleEvil = new(12);
        public static readonly AreaOfEffectType CircleGood = new(13);
        public static readonly AreaOfEffectType CircleLaw = new(14);
        public static readonly AreaOfEffectType CircleChaos = new(15);
        public static readonly AreaOfEffectType Fear = new(16);
        public static readonly AreaOfEffectType Blinding = new(17);
        public static readonly AreaOfEffectType Unearthly = new(18);
        public static readonly AreaOfEffectType Menace = new(19);
        public static readonly AreaOfEffectType Unnatural = new(20);
        public static readonly AreaOfEffectType Stun = new(21);
        public static readonly AreaOfEffectType Protection = new(22);
        public static readonly AreaOfEffectType Fire = new(23);
        public static readonly AreaOfEffectType Frost = new(24);
        public static readonly AreaOfEffectType Electrical = new(25);
        public static readonly AreaOfEffectType FogGhoul = new(26);
        public static readonly AreaOfEffectType TyrantFog = new(27);
        public static readonly AreaOfEffectType Storm = new(28);
        public static readonly AreaOfEffectType InvisibilitySphere = new(29);
        public static readonly AreaOfEffectType Silence = new(30);
        public static readonly AreaOfEffectType DelayBlastFireball = new(31);
        public static readonly AreaOfEffectType Grease = new(32);
        public static readonly AreaOfEffectType CreepingDoom = new(33);
        public static readonly AreaOfEffectType EvardsBlackTentacles = new(34);
        public static readonly AreaOfEffectType InvisibilityPurge = new(35);
        public static readonly AreaOfEffectType DragonFear = new(36);
        public static readonly AreaOfEffectType CustomAoe = new(37);
        public static readonly AreaOfEffectType GlyphOfWarding = new(38);
        public static readonly AreaOfEffectType FogOfBewilderment = new(39);
        public static readonly AreaOfEffectType VineMineCamouflage = new(40);
        public static readonly AreaOfEffectType TideOfBattle = new(41);
        public static readonly AreaOfEffectType StoneHold = new(42);
        public static readonly AreaOfEffectType OverMind = new(43);
        public static readonly AreaOfEffectType HorrificAppearance = new(44);
        public static readonly AreaOfEffectType TroglodyteStench = new(45);
        public static readonly AreaOfEffectType NightmareSmoke = new(46);
        public static readonly AreaOfEffectType PitTrap = new(52);
        public static readonly AreaOfEffectType PitTrap2 = new(53);
        public static readonly AreaOfEffectType WhirlingBlade = new(54);
        public static readonly AreaOfEffectType CustomAOE10Good = new(56);
        public static readonly AreaOfEffectType CustomAO20Good = new(57);
        public static readonly AreaOfEffectType CustomAOE30Good = new(58);
        public static readonly AreaOfEffectType CustomAOE10Evil = new(59);
        public static readonly AreaOfEffectType CustomAOE20Evil = new(60);
        public static readonly AreaOfEffectType CustomAOE30Evil = new(61);
        public static readonly AreaOfEffectType CustomAOE10Odd = new(62);
        public static readonly AreaOfEffectType CustomAOE20Odd = new(63);
        public static readonly AreaOfEffectType CustomAOE30Odd = new(64);

        public AreaOfEffectType(int internalValue) : base(internalValue)
        {
        }
    }
}