namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyTrapType: NWEnumBase<int>
    {
        public static readonly ItemPropertyTrapType Spike = new(1);
        public static readonly ItemPropertyTrapType Holy = new(2);
        public static readonly ItemPropertyTrapType Tangle = new(3);
        public static readonly ItemPropertyTrapType BlobOfAcid = new(4);
        public static readonly ItemPropertyTrapType Fire = new(5);
        public static readonly ItemPropertyTrapType Electrical = new(6);
        public static readonly ItemPropertyTrapType Gas = new(7);
        public static readonly ItemPropertyTrapType Frost = new(8);
        public static readonly ItemPropertyTrapType AcidSplash = new(9);
        public static readonly ItemPropertyTrapType Sonic = new(10);
        public static readonly ItemPropertyTrapType Negative = new(11);

        public ItemPropertyTrapType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ItemPropertyTrapType(int internalValue) => new(internalValue);
    }
}