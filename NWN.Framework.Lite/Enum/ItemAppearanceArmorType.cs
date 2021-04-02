namespace NWN.Framework.Lite.Enum
{
    public class ItemAppearanceArmorType: NWEnumBase<int>
    {
        public static readonly ItemAppearanceArmorType RightFoot = new(0);
        public static readonly ItemAppearanceArmorType LeftFoot = new(1);
        public static readonly ItemAppearanceArmorType RightShin = new(2);
        public static readonly ItemAppearanceArmorType LeftShin = new(3);
        public static readonly ItemAppearanceArmorType LeftThigh = new(4);
        public static readonly ItemAppearanceArmorType RightThigh = new(5);
        public static readonly ItemAppearanceArmorType Pelvis = new(6);
        public static readonly ItemAppearanceArmorType Torso = new(7);
        public static readonly ItemAppearanceArmorType Belt = new(8);
        public static readonly ItemAppearanceArmorType Neck = new(9);
        public static readonly ItemAppearanceArmorType RightForearm = new(10);
        public static readonly ItemAppearanceArmorType LeftForearm = new(11);
        public static readonly ItemAppearanceArmorType RightBicep = new(12);
        public static readonly ItemAppearanceArmorType LeftBicep = new(13);
        public static readonly ItemAppearanceArmorType RightShoulder = new(14);
        public static readonly ItemAppearanceArmorType LeftShoulder = new(15);
        public static readonly ItemAppearanceArmorType RightHand = new(16);
        public static readonly ItemAppearanceArmorType LeftHand = new(17);
        public static readonly ItemAppearanceArmorType Robe = new(18);
        public static readonly ItemAppearanceArmorType Num = new(19);

        public ItemAppearanceArmorType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ItemAppearanceArmorType(int internalValue) => new(internalValue);
    }
}