namespace NWN.Framework.Lite.Enum
{
    public class ItemAppearanceType: NWEnumBase<int>
    {
        public static readonly ItemAppearanceType Color_Leather1 = new(-9);
        public static readonly ItemAppearanceType Color_Leather2 = new(-8);
        public static readonly ItemAppearanceType Color_Cloth1 = new(-7);
        public static readonly ItemAppearanceType Color_Cloth2 = new(-6);
        public static readonly ItemAppearanceType Color_Metal1 = new(-5);
        public static readonly ItemAppearanceType Color_Metal2 = new(-4);
        public static readonly ItemAppearanceType Model_Part1 = new(-3);
        public static readonly ItemAppearanceType Model_Part2 = new(-2);
        public static readonly ItemAppearanceType Model_Part3 = new(-1);
        public static readonly ItemAppearanceType ArmorModel_RightFoot = new(0);
        public static readonly ItemAppearanceType ArmorModel_LeftFoot = new(1);
        public static readonly ItemAppearanceType ArmorModel_RightShin = new(2);
        public static readonly ItemAppearanceType ArmorModel_LeftShin = new(3);
        public static readonly ItemAppearanceType ArmorModel_LeftThigh = new(4);
        public static readonly ItemAppearanceType ArmorModel_RightThigh = new(5);
        public static readonly ItemAppearanceType ArmorModel_Pelvis = new(6);
        public static readonly ItemAppearanceType ArmorModel_Torso = new(7);
        public static readonly ItemAppearanceType ArmorModel_Belt = new(8);
        public static readonly ItemAppearanceType ArmorModel_Neck = new(9);
        public static readonly ItemAppearanceType ArmorModel_RightForearm = new(10);
        public static readonly ItemAppearanceType ArmorModel_LeftForearm = new(11);
        public static readonly ItemAppearanceType ArmorModel_RightBicep = new(12);
        public static readonly ItemAppearanceType ArmorModel_LeftBicep = new(13);
        public static readonly ItemAppearanceType ArmorModel_RightShoulder = new(14);
        public static readonly ItemAppearanceType ArmorModel_LeftShoulder = new(15);
        public static readonly ItemAppearanceType ArmorModel_RightHand = new(16);
        public static readonly ItemAppearanceType ArmorModel_LeftHand = new(17);
        public static readonly ItemAppearanceType ArmorModel_Robe = new(18);

        public ItemAppearanceType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ItemAppearanceType(int internalValue) => new(internalValue);
    }
}