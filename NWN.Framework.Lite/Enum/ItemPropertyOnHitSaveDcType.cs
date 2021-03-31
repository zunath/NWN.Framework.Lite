namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyOnHitSaveDcType: NWEnumBase<int>
    {
        public static readonly ItemPropertyOnHitSaveDcType Fourteen = new(0);
        public static readonly ItemPropertyOnHitSaveDcType Sixteen = new(1);
        public static readonly ItemPropertyOnHitSaveDcType Eighteen = new(2);
        public static readonly ItemPropertyOnHitSaveDcType Twenty = new(3);
        public static readonly ItemPropertyOnHitSaveDcType TwentyTwo = new(4);
        public static readonly ItemPropertyOnHitSaveDcType TwentyFour = new(5);
        public static readonly ItemPropertyOnHitSaveDcType TwentySix = new(6);

        public ItemPropertyOnHitSaveDcType(int internalValue) : base(internalValue)
        {
        }
    }
}