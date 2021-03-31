namespace NWN.Framework.Lite.Enum
{
    public class SpecialAttackType : NWEnumBase<int>
    {
        public static readonly SpecialAttackType Invalid = new(0);
        public static readonly SpecialAttackType CalledShotLeg = new(1);
        public static readonly SpecialAttackType CalledShotArm = new(2);
        public static readonly SpecialAttackType Sap = new(3);
        public static readonly SpecialAttackType Disarm = new(4);
        public static readonly SpecialAttackType ImprovedDisarm = new(5);
        public static readonly SpecialAttackType Knockdown = new(6);
        public static readonly SpecialAttackType ImprovedKnockdown = new(7);
        public static readonly SpecialAttackType StunningFist = new(8);
        public static readonly SpecialAttackType FlurryOfBlows = new(9);
        public static readonly SpecialAttackType RapidShot = new(10);

        public SpecialAttackType(int internalValue) : base(internalValue) { }
    }
}