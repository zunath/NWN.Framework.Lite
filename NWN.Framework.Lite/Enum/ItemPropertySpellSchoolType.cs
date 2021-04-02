namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertySpellSchoolType: NWEnumBase<int>
    {
        public static readonly ItemPropertySpellSchoolType Abjuration = new(0);
        public static readonly ItemPropertySpellSchoolType Conjuration = new(1);
        public static readonly ItemPropertySpellSchoolType Divination = new(2);
        public static readonly ItemPropertySpellSchoolType Enchantment = new(3);
        public static readonly ItemPropertySpellSchoolType Evocation = new(4);
        public static readonly ItemPropertySpellSchoolType Illusion = new(5);
        public static readonly ItemPropertySpellSchoolType Necromancy = new(6);
        public static readonly ItemPropertySpellSchoolType Transmutation = new(7);

        public ItemPropertySpellSchoolType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ItemPropertySpellSchoolType(int internalValue) => new(internalValue);
    }
}