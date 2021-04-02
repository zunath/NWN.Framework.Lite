namespace NWN.Framework.Lite.Enum
{
    public class ItemColorModelAppearanceType: NWEnumBase<int>
    {
        public static readonly ItemColorModelAppearanceType SimpleModel = new(0);
        public static readonly ItemColorModelAppearanceType WeaponColor = new(1);
        public static readonly ItemColorModelAppearanceType WeaponModel = new(2);
        public static readonly ItemColorModelAppearanceType ArmorModel = new(3);
        public static readonly ItemColorModelAppearanceType ArmorColor = new(4);

        public ItemColorModelAppearanceType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ItemColorModelAppearanceType(int internalValue) => new(internalValue);
    }
}