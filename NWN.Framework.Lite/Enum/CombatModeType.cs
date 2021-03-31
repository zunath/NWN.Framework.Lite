namespace NWN.Framework.Lite.Enum
{
    public class CombatModeType: NWEnumBase<int>
    {
        public static readonly CombatModeType Invalid = new(0);
        public static readonly CombatModeType Parry = new(1);
        public static readonly CombatModeType PowerAttack = new(2);
        public static readonly CombatModeType ImprovedPowerAttack = new(3);
        public static readonly CombatModeType FlurryOfBlows = new(4);
        public static readonly CombatModeType RapidShot = new(5);
        public static readonly CombatModeType Expertise = new(6);
        public static readonly CombatModeType ImprovedExpertise = new(7);
        public static readonly CombatModeType DefensiveCasting = new(8);
        public static readonly CombatModeType DirtyFighting = new(9);
        public static readonly CombatModeType DefensiveStance = new(10);

        public CombatModeType(int internalValue) : base(internalValue)
        {
        }
    }
}