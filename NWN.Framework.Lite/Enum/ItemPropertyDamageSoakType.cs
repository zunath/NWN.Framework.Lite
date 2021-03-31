namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyDamageSoakType: NWEnumBase<int>
    {
        public static readonly ItemPropertyDamageSoakType FiveHP = new(1);
        public static readonly ItemPropertyDamageSoakType TenHP = new(2);
        public static readonly ItemPropertyDamageSoakType FifteenHP = new(3);
        public static readonly ItemPropertyDamageSoakType TwentyHP = new(4);
        public static readonly ItemPropertyDamageSoakType TwentyFiveHP = new(5);
        public static readonly ItemPropertyDamageSoakType ThirtyHP = new(6);
        public static readonly ItemPropertyDamageSoakType ThirtyFiveHP = new(7);
        public static readonly ItemPropertyDamageSoakType FortyHP = new(8);
        public static readonly ItemPropertyDamageSoakType FiftyFiveHP = new(9);
        public static readonly ItemPropertyDamageSoakType FiftyHP = new(10);

        public ItemPropertyDamageSoakType(int internalValue) : base(internalValue)
        {
        }
    }
}