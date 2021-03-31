namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyOnHitDurationType: NWEnumBase<int>
    {
        public static readonly ItemPropertyOnHitDurationType FivePercent5Rounds = new(0);
        public static readonly ItemPropertyOnHitDurationType TenPercent4Rounds = new(1);
        public static readonly ItemPropertyOnHitDurationType TwentyFivePercent3Rounds = new(2);
        public static readonly ItemPropertyOnHitDurationType FiftyPercent2Rounds = new(3);
        public static readonly ItemPropertyOnHitDurationType SeventyFivePercent1Round = new(4);

        public ItemPropertyOnHitDurationType(int internalValue) : base(internalValue)
        {
        }
    }
}