namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyCastSpellNumberUsesType: NWEnumBase<int>
    {
        public static readonly ItemPropertyCastSpellNumberUsesType SingleUse = new(1);
        public static readonly ItemPropertyCastSpellNumberUsesType FiveChargesPerUse = new(2);
        public static readonly ItemPropertyCastSpellNumberUsesType FourChargesPerUse = new(3);
        public static readonly ItemPropertyCastSpellNumberUsesType ThreeChargesPerUse = new(4);
        public static readonly ItemPropertyCastSpellNumberUsesType TwoChargesPerUse = new(5);
        public static readonly ItemPropertyCastSpellNumberUsesType OneChargesPerUse = new(6);
        public static readonly ItemPropertyCastSpellNumberUsesType ZeroChargesPerUse = new(7);
        public static readonly ItemPropertyCastSpellNumberUsesType OneUsePerDay = new(8);
        public static readonly ItemPropertyCastSpellNumberUsesType TwoUsesPerDay = new(9);
        public static readonly ItemPropertyCastSpellNumberUsesType ThreeUsesPerDay = new(10);
        public static readonly ItemPropertyCastSpellNumberUsesType FourUsesPerDay = new(11);
        public static readonly ItemPropertyCastSpellNumberUsesType FiveUsesPerDay = new(12);
        public static readonly ItemPropertyCastSpellNumberUsesType UnlimitedUse = new(13);

        public ItemPropertyCastSpellNumberUsesType(int internalValue) : base(internalValue)
        {
        }
    }
}