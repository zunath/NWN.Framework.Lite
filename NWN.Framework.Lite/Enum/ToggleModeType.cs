namespace NWN.Framework.Lite.Enum
{
    public class ToggleModeType: NWEnumBase<int>
    {
        public static readonly ToggleModeType Detect = new(0);
        public static readonly ToggleModeType Stealth = new(1);
        public static readonly ToggleModeType Parry = new(2);
        public static readonly ToggleModeType PowerAttack = new(3);
        public static readonly ToggleModeType ImprovedPowerAttack = new(4);
        public static readonly ToggleModeType CounterSpell = new(5);
        public static readonly ToggleModeType FlurryOfBlows = new(6);
        public static readonly ToggleModeType RapidShot = new(7);
        public static readonly ToggleModeType Expertise = new(8);
        public static readonly ToggleModeType ImprovedExpertise = new(9);
        public static readonly ToggleModeType DefensiveCast = new(10);
        public static readonly ToggleModeType DirtyFighting = new(11);
        public static readonly ToggleModeType DefensiveStance = new(12);

        public ToggleModeType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ToggleModeType(int internalValue) => new(internalValue);
    }
}
