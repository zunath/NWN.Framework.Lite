namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyAbilityType: NWEnumBase<int>
    {
        public static readonly ItemPropertyAbilityType Strength = new(0);
        public static readonly ItemPropertyAbilityType Dexterity = new(1);
        public static readonly ItemPropertyAbilityType Constitution = new(2);
        public static readonly ItemPropertyAbilityType Intelligence = new(3);
        public static readonly ItemPropertyAbilityType Wisdom = new(4);
        public static readonly ItemPropertyAbilityType Charisma = new(5);

        public ItemPropertyAbilityType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ItemPropertyAbilityType(int internalValue) => new(internalValue);
    }
}