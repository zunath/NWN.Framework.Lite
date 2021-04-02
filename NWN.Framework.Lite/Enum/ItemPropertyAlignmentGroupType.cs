namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyAlignmentGroupType: NWEnumBase<int>
    {
        public static readonly ItemPropertyAlignmentGroupType All = new(0);
        public static readonly ItemPropertyAlignmentGroupType Neutral = new(1);
        public static readonly ItemPropertyAlignmentGroupType Lawful = new(2);
        public static readonly ItemPropertyAlignmentGroupType Chaotic = new(3);
        public static readonly ItemPropertyAlignmentGroupType Good = new(4);
        public static readonly ItemPropertyAlignmentGroupType Evil = new(5);

        public ItemPropertyAlignmentGroupType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ItemPropertyAlignmentGroupType(int internalValue) => new(internalValue);
    }
}