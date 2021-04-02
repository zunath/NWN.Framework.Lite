namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyArmorClassModifierType: NWEnumBase<int>
    {
        public static readonly ItemPropertyArmorClassModifierType Dodge = new(0);
        public static readonly ItemPropertyArmorClassModifierType Natural = new(1);
        public static readonly ItemPropertyArmorClassModifierType Armor = new(2);
        public static readonly ItemPropertyArmorClassModifierType Shield = new(3);
        public static readonly ItemPropertyArmorClassModifierType Deflection = new(4);

        public ItemPropertyArmorClassModifierType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ItemPropertyArmorClassModifierType(int internalValue) => new(internalValue);
    }
}