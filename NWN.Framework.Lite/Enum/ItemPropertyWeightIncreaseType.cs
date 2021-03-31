namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyWeightIncreaseType: NWEnumBase<int>
    {
        public static readonly ItemPropertyWeightIncreaseType FivePounds = new(0);
        public static readonly ItemPropertyWeightIncreaseType TenPounds = new(1);
        public static readonly ItemPropertyWeightIncreaseType FifteenPounds = new(2);
        public static readonly ItemPropertyWeightIncreaseType ThirtyPounds = new(3);
        public static readonly ItemPropertyWeightIncreaseType FiftyPounds = new(4);
        public static readonly ItemPropertyWeightIncreaseType HundredPounds = new(5);

        public ItemPropertyWeightIncreaseType(int internalValue) : base(internalValue)
        {
        }
    }
}