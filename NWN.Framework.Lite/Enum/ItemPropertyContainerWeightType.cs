namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyContainerWeightType: NWEnumBase<int>
    {
        public static readonly ItemPropertyContainerWeightType TwentyPercent = new(1);
        public static readonly ItemPropertyContainerWeightType FourtyPercent = new(2);
        public static readonly ItemPropertyContainerWeightType SixtyPercent = new(3);
        public static readonly ItemPropertyContainerWeightType EightyPercent = new(4);
        public static readonly ItemPropertyContainerWeightType HundredPercent = new(5);

        public ItemPropertyContainerWeightType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ItemPropertyContainerWeightType(int internalValue) => new(internalValue);
    }
}