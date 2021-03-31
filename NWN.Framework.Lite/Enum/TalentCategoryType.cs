namespace NWN.Framework.Lite.Enum
{
    public class TalentCategoryType : NWEnumBase<int>
    {
        // These must match the list in nwscreaturestats.cpp
        public static readonly TalentCategoryType Harmful_Areaeffect_Discriminant = new(1);
        public static readonly TalentCategoryType Harmful_Ranged = new(2);
        public static readonly TalentCategoryType Harmful_Touch = new(3);
        public static readonly TalentCategoryType Beneficial_Healing_Areaeffect = new(4);
        public static readonly TalentCategoryType Beneficial_Healing_Touch = new(5);
        public static readonly TalentCategoryType Beneficial_Conditional_Areaeffect = new(6);
        public static readonly TalentCategoryType Beneficial_Conditional_Single = new(7);
        public static readonly TalentCategoryType Beneficial_Enhancement_Areaeffect = new(8);
        public static readonly TalentCategoryType Beneficial_Enhancement_Single = new(9);
        public static readonly TalentCategoryType Beneficial_Enhancement_Self = new(10);
        public static readonly TalentCategoryType Harmful_Areaeffect_Indiscriminant = new(11);
        public static readonly TalentCategoryType Beneficial_Protection_Self = new(12);
        public static readonly TalentCategoryType Beneficial_Protection_Single = new(13);
        public static readonly TalentCategoryType Beneficial_Protection_Areaeffect = new(14);
        public static readonly TalentCategoryType Beneficial_Obtain_Allies = new(15);
        public static readonly TalentCategoryType Persistent_Area_Of_Effect = new(16);
        public static readonly TalentCategoryType Beneficial_Healing_Potion = new(17);
        public static readonly TalentCategoryType Beneficial_Conditional_Potion = new(18);
        public static readonly TalentCategoryType Dragons_Breath = new(19);
        public static readonly TalentCategoryType Beneficial_Protection_Potion = new(20);
        public static readonly TalentCategoryType Beneficial_Enhancement_Potion = new(21);
        public static readonly TalentCategoryType Harmful_Melee = new(22);

        public TalentCategoryType(int internalValue) : base(internalValue) { }
    }
}