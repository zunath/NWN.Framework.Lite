namespace NWN.Framework.Lite.Enum
{
    public class SpellSchoolType : NWEnumBase<int>
    {
        public static readonly SpellSchoolType General = new(0);
        public static readonly SpellSchoolType Abjuration = new(1);
        public static readonly SpellSchoolType Conjuration = new(2);
        public static readonly SpellSchoolType Divination = new(3);
        public static readonly SpellSchoolType Enchantment = new(4);
        public static readonly SpellSchoolType Evocation = new(5);
        public static readonly SpellSchoolType Illusion = new(6);
        public static readonly SpellSchoolType Necromancy = new(7);
        public static readonly SpellSchoolType Transmutation = new(8);

        public SpellSchoolType(int internalValue) : base(internalValue)
        {

        }

        public static explicit operator SpellSchoolType(int internalValue) => new(internalValue);
    }
}