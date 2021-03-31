namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyAlignmentType: NWEnumBase<int>
    {
        public static readonly ItemPropertyAlignmentType LawfulGood = new(0);
        public static readonly ItemPropertyAlignmentType LawfulNeutral = new(1);
        public static readonly ItemPropertyAlignmentType LawfulEvil = new(2);
        public static readonly ItemPropertyAlignmentType NeutralGood = new(3);
        public static readonly ItemPropertyAlignmentType TrueNeutral = new(4);
        public static readonly ItemPropertyAlignmentType NeutralEvil = new(5);
        public static readonly ItemPropertyAlignmentType ChaoticGood = new(6);
        public static readonly ItemPropertyAlignmentType ChaoticNeutral = new(7);
        public static readonly ItemPropertyAlignmentType ChaoticEvil = new(8);

        public ItemPropertyAlignmentType(int internalValue) : base(internalValue)
        {
        }
    }
}