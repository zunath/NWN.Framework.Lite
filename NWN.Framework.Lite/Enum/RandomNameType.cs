namespace NWN.Framework.Lite.Enum
{
    public class RandomNameType : NWEnumBase<int>
    {
        // These constants determine which name table to use when generating random names.

        public static readonly RandomNameType FirstGenericMale = new(-1);
        public static readonly RandomNameType Animal = new(0);
        public static readonly RandomNameType Familiar = new(1);
        public static readonly RandomNameType FirstDwarfMale = new(2);
        public static readonly RandomNameType FirstDwarfFemale = new(3);
        public static readonly RandomNameType LastDwarf = new(4);
        public static readonly RandomNameType FirstElfMale = new(5);
        public static readonly RandomNameType FirstElfFemale = new(6);
        public static readonly RandomNameType LastElf = new(7);
        public static readonly RandomNameType FirstGnomeMale = new(8);
        public static readonly RandomNameType FirstGnomeFemale = new(9);
        public static readonly RandomNameType LastGnome = new(10);
        public static readonly RandomNameType FirstHalfelfMale = new(11);
        public static readonly RandomNameType FirstHalfElfFemale = new(12);
        public static readonly RandomNameType LastHalfElf = new(13);
        public static readonly RandomNameType FirstHalflingMale = new(14);
        public static readonly RandomNameType FirstHalflingFemale = new(15);
        public static readonly RandomNameType LastHalfling = new(16);
        public static readonly RandomNameType FirstHalfOrcMale = new(17);
        public static readonly RandomNameType FirstHalfOrcFemale = new(18);
        public static readonly RandomNameType LastHalfOrc = new(19);
        public static readonly RandomNameType FirstHumanMale = new(20);
        public static readonly RandomNameType FirstHumanFemale = new(21);
        public static readonly RandomNameType LastHuman = new(22);

        public RandomNameType(int internalValue) : base(internalValue) { }
    }
}