namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyQualityType: NWEnumBase<int>
    {
        public static readonly ItemPropertyQualityType Unknown = new(0);
        public static readonly ItemPropertyQualityType Destroyed = new(1);
        public static readonly ItemPropertyQualityType Ruined = new(2);
        public static readonly ItemPropertyQualityType VeryPoor = new(3);
        public static readonly ItemPropertyQualityType Poor = new(4);
        public static readonly ItemPropertyQualityType BelowAverage = new(5);
        public static readonly ItemPropertyQualityType Average = new(6);
        public static readonly ItemPropertyQualityType AboveAverage = new(7);
        public static readonly ItemPropertyQualityType Good = new(8);
        public static readonly ItemPropertyQualityType VeryGood = new(9);
        public static readonly ItemPropertyQualityType Excellent = new(10);
        public static readonly ItemPropertyQualityType Masterwork = new(11);
        public static readonly ItemPropertyQualityType GodLike = new(12);
        public static readonly ItemPropertyQualityType Raw = new(13);
        public static readonly ItemPropertyQualityType Cut = new(14);
        public static readonly ItemPropertyQualityType Polished = new(15);

        public ItemPropertyQualityType(int internalValue) : base(internalValue)
        {
        }
    }
}