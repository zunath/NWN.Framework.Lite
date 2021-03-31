namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyUnlimitedType: NWEnumBase<int>
    {
        public static readonly ItemPropertyUnlimitedType Basic = new(1);
        public static readonly ItemPropertyUnlimitedType OneD6Fire = new(2);
        public static readonly ItemPropertyUnlimitedType OneD6Cold = new(3);
        public static readonly ItemPropertyUnlimitedType OneD6Light = new(4);
        public static readonly ItemPropertyUnlimitedType Plus1 = new(11);
        public static readonly ItemPropertyUnlimitedType Plus2 = new(12);
        public static readonly ItemPropertyUnlimitedType Plus3 = new(13);
        public static readonly ItemPropertyUnlimitedType Plus4 = new(14);
        public static readonly ItemPropertyUnlimitedType Plus5 = new(15);

        public ItemPropertyUnlimitedType(int internalValue) : base(internalValue)
        {
        }
    }
}