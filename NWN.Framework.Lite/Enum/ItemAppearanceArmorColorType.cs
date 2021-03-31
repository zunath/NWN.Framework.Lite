namespace NWN.Framework.Lite.Enum
{
    public class ItemAppearanceArmorColorType: NWEnumBase<int>
    {
        public static readonly ItemAppearanceArmorColorType Leather1 = new(0);
        public static readonly ItemAppearanceArmorColorType Leather2 = new(1);
        public static readonly ItemAppearanceArmorColorType Cloth1 = new(2);
        public static readonly ItemAppearanceArmorColorType Cloth2 = new(3);
        public static readonly ItemAppearanceArmorColorType Metal1 = new(4);
        public static readonly ItemAppearanceArmorColorType Metal2 = new(5);
        public static readonly ItemAppearanceArmorColorType NumColors = new(6);

        public ItemAppearanceArmorColorType(int internalValue) : base(internalValue)
        {
        }
    }
}