namespace NWN.Framework.Lite.Enum
{
    public class ItemVisualType: NWEnumBase<int>
    {
        public static readonly ItemVisualType Acid = new(0);
        public static readonly ItemVisualType Cold = new(1);
        public static readonly ItemVisualType Electrical = new(2);
        public static readonly ItemVisualType Fire = new(3);
        public static readonly ItemVisualType Sonic = new(4);
        public static readonly ItemVisualType Holy = new(5);
        public static readonly ItemVisualType Evil = new(6);

        public ItemVisualType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ItemVisualType(int internalValue) => new(internalValue);
    }
}