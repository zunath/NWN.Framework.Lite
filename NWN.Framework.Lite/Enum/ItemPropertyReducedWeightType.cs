namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyReducedWeightType: NWEnumBase<int>
    {
        public static readonly ItemPropertyReducedWeightType EightyPercent = new(1);
        public static readonly ItemPropertyReducedWeightType SixtyPercent = new(2);
        public static readonly ItemPropertyReducedWeightType FourtyPercent = new(3);
        public static readonly ItemPropertyReducedWeightType TwentyPercent = new(4);
        public static readonly ItemPropertyReducedWeightType TenPercent = new(5);

        public ItemPropertyReducedWeightType(int internalValue) : base(internalValue)
        {
        }
    }
}