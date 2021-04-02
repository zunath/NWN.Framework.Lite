namespace NWN.Framework.Lite.Enum
{
    // should be the same as in nwseffectlist.cpp
    public class AbilityType: NWEnumBase<int>
    {
        public static readonly AbilityType Invalid = new (-1);
        public static readonly AbilityType Strength = new(0);
        public static readonly AbilityType Dexterity = new(1);
        public static readonly AbilityType Constitution = new(2);
        public static readonly AbilityType Intelligence = new(3);
        public static readonly AbilityType Wisdom = new(4);
        public static readonly AbilityType Charisma = new(5);

        public AbilityType(int internalValue) 
            : base(internalValue)
        {
        }

        public static explicit operator AbilityType(int internalValue) => new(internalValue);
    }
}