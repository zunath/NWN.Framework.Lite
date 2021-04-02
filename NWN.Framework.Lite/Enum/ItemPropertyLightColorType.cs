namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyLightColorType: NWEnumBase<int>
    {
        public static readonly ItemPropertyLightColorType Blue = new(0);
        public static readonly ItemPropertyLightColorType Yellow = new(1);
        public static readonly ItemPropertyLightColorType Purple = new(2);
        public static readonly ItemPropertyLightColorType Red = new(3);
        public static readonly ItemPropertyLightColorType Green = new(4);
        public static readonly ItemPropertyLightColorType Orange = new(5);
        public static readonly ItemPropertyLightColorType White = new(6);

        public ItemPropertyLightColorType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ItemPropertyLightColorType(int internalValue) => new(internalValue);
    }
}