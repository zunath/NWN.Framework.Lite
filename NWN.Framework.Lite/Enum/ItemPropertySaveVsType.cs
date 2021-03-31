namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertySaveVsType: NWEnumBase<int>
    {
        public static readonly ItemPropertySaveVsType Acid = new(1);
        public static readonly ItemPropertySaveVsType Cold = new(3);
        public static readonly ItemPropertySaveVsType Death = new(4);
        public static readonly ItemPropertySaveVsType Disease = new(5);
        public static readonly ItemPropertySaveVsType Divine = new(6);
        public static readonly ItemPropertySaveVsType Electrical = new(7);
        public static readonly ItemPropertySaveVsType Fear = new(8);
        public static readonly ItemPropertySaveVsType Fire = new(9);
        public static readonly ItemPropertySaveVsType MindAffecting = new(11);
        public static readonly ItemPropertySaveVsType Negative = new(12);
        public static readonly ItemPropertySaveVsType Poison = new(13);
        public static readonly ItemPropertySaveVsType Positive = new(14);
        public static readonly ItemPropertySaveVsType Sonic = new(15);
        public static readonly ItemPropertySaveVsType Universal = new(0);

        public ItemPropertySaveVsType(int internalValue) : base(internalValue)
        {
        }
    }
}