namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertySpellResistanceBonusType: NWEnumBase<int>
    {
        public static readonly ItemPropertySpellResistanceBonusType Ten = new(0);
        public static readonly ItemPropertySpellResistanceBonusType Twelve = new(1);
        public static readonly ItemPropertySpellResistanceBonusType Fourteen = new(2);
        public static readonly ItemPropertySpellResistanceBonusType Sixteen = new(3);
        public static readonly ItemPropertySpellResistanceBonusType Eighteen = new(4);
        public static readonly ItemPropertySpellResistanceBonusType Twenty = new(5);
        public static readonly ItemPropertySpellResistanceBonusType TwentyTwo = new(6);
        public static readonly ItemPropertySpellResistanceBonusType TwentyFour = new(7);
        public static readonly ItemPropertySpellResistanceBonusType TwentySix = new(8);
        public static readonly ItemPropertySpellResistanceBonusType TwentyEight = new(9);
        public static readonly ItemPropertySpellResistanceBonusType Thirty = new(10);
        public static readonly ItemPropertySpellResistanceBonusType ThirtyTwo = new(11);

        public ItemPropertySpellResistanceBonusType(int internalValue) : base(internalValue)
        {
        }
    }
}