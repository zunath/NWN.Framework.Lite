namespace NWN.Framework.Lite.Enum
{
    public class ActionModeType
    {
        public static readonly ActionModeType Detect = new(0);
        public static readonly ActionModeType Stealth = new(1);
        public static readonly ActionModeType Parry = new(2);
        public static readonly ActionModeType PowerAttack = new(3);
        public static readonly ActionModeType ImprovedPowerAttack = new(4);
        public static readonly ActionModeType CounterSpell = new(5);
        public static readonly ActionModeType FlurryOfBlows = new(6);
        public static readonly ActionModeType RapidShot = new(7);
        public static readonly ActionModeType Expertise = new(8);
        public static readonly ActionModeType ImprovedExpertise = new(9);
        public static readonly ActionModeType DefensiveCast = new(10);
        public static readonly ActionModeType DirtyFighting = new(11);

        public int InternalValue { get; protected set; }

        public ActionModeType(int internalValue)
        {
            InternalValue = internalValue;
        }
    }
}