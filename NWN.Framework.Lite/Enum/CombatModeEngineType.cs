namespace NWN.Framework.Lite.Enum
{
    public class CombatModeEngineType: NWEnumBase<int>
    {
        public static readonly CombatModeEngineType None = new(0);
        public static readonly CombatModeEngineType Parry = new(1);
        public static readonly CombatModeEngineType PowerAttack = new(2);
        public static readonly CombatModeEngineType ImprovedPowerAttack = new(3);
        public static readonly CombatModeEngineType CounterSpell = new(4);
        public static readonly CombatModeEngineType FlurryOfBlows = new(5);
        public static readonly CombatModeEngineType RapidShot = new(6);
        public static readonly CombatModeEngineType Expertise = new(7);
        public static readonly CombatModeEngineType ImprovedExpertise = new(8);
        public static readonly CombatModeEngineType DefensiveCasting = new(9);
        public static readonly CombatModeEngineType DirtyFighting = new(10);
        public static readonly CombatModeEngineType DefensiveStance = new(11);

        public CombatModeEngineType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator CombatModeEngineType(int internalValue) => new(internalValue);
    }
}