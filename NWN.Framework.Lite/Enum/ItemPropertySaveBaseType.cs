namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertySaveBaseType: NWEnumBase<int>
    {
        public static readonly ItemPropertySaveBaseType Fortitude = new(1);
        public static readonly ItemPropertySaveBaseType Will = new(2);
        public static readonly ItemPropertySaveBaseType Reflex = new(3);

        public ItemPropertySaveBaseType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ItemPropertySaveBaseType(int internalValue) => new(internalValue);
    }
}