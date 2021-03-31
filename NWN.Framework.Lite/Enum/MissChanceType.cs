namespace NWN.Framework.Lite.Enum
{
    public class MissChanceType : NWEnumBase<int>
    {
        public static readonly MissChanceType Normal = new(0);
        public static readonly MissChanceType Ranged = new(1);
        public static readonly MissChanceType Melee = new(2);

        public MissChanceType(int internalValue) : base(internalValue) { }
    }
}