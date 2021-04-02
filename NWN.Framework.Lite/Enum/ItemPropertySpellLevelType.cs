namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertySpellLevelType: NWEnumBase<int>
    {
        public static readonly ItemPropertySpellLevelType SpellLevel0 = new(0);
        public static readonly ItemPropertySpellLevelType SpellLevel1 = new(1);
        public static readonly ItemPropertySpellLevelType SpellLevel2 = new(2);
        public static readonly ItemPropertySpellLevelType SpellLevel3 = new(3);
        public static readonly ItemPropertySpellLevelType SpellLevel4 = new(4);
        public static readonly ItemPropertySpellLevelType SpellLevel5 = new(5);
        public static readonly ItemPropertySpellLevelType SpellLevel6 = new(6);
        public static readonly ItemPropertySpellLevelType SpellLevel7 = new(7);
        public static readonly ItemPropertySpellLevelType SpellLevel8 = new(8);
        public static readonly ItemPropertySpellLevelType SpellLevel9 = new(9);

        public ItemPropertySpellLevelType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ItemPropertySpellLevelType(int internalValue) => new(internalValue);
    }
}