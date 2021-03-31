namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyUseLimitationClassType: NWEnumBase<int>
    {
        public static readonly ItemPropertyUseLimitationClassType Barbarian = new(0);
        public static readonly ItemPropertyUseLimitationClassType Bard = new(1);
        public static readonly ItemPropertyUseLimitationClassType Cleric = new(2);
        public static readonly ItemPropertyUseLimitationClassType Druid = new(3);
        public static readonly ItemPropertyUseLimitationClassType Fighter = new(4);
        public static readonly ItemPropertyUseLimitationClassType Monk = new(5);
        public static readonly ItemPropertyUseLimitationClassType Paladin = new(6);
        public static readonly ItemPropertyUseLimitationClassType Ranger = new(7);
        public static readonly ItemPropertyUseLimitationClassType Rogue = new(8);
        public static readonly ItemPropertyUseLimitationClassType Sorcerer = new(9);
        public static readonly ItemPropertyUseLimitationClassType Wizard = new(10);

        public ItemPropertyUseLimitationClassType(int internalValue) : base(internalValue)
        {
        }
    }
}