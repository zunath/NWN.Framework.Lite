namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyTrapStrengthType: NWEnumBase<int>
    {
        public static readonly ItemPropertyTrapStrengthType Minor = new(0);
        public static readonly ItemPropertyTrapStrengthType Average = new(1);
        public static readonly ItemPropertyTrapStrengthType Strong = new(2);
        public static readonly ItemPropertyTrapStrengthType Deadly = new(3);

        public ItemPropertyTrapStrengthType(int internalValue) : base(internalValue)
        {
        }
    }
}