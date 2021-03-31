namespace NWN.Framework.Lite.Enum
{
    public class RacialType: NWEnumBase<int>
    {
        public static readonly RacialType Dwarf = new(0);
        public static readonly RacialType Elf = new(1);
        public static readonly RacialType Gnome = new(2);
        public static readonly RacialType Halfling = new(3);
        public static readonly RacialType Halfelf = new(4);
        public static readonly RacialType Halforc = new(5);
        public static readonly RacialType Human = new(6);
        public static readonly RacialType Aberration = new(7);
        public static readonly RacialType Animal = new(8);
        public static readonly RacialType Beast = new(9);
        public static readonly RacialType Construct = new(10);
        public static readonly RacialType Dragon = new(11);
        public static readonly RacialType HumanoidGoblinoid = new(12);
        public static readonly RacialType HumanoidMonstrous = new(13);
        public static readonly RacialType HumanoidOrc = new(14);
        public static readonly RacialType HumanoidReptilian = new(15);
        public static readonly RacialType Elemental = new(16);
        public static readonly RacialType Fey = new(17);
        public static readonly RacialType Giant = new(18);
        public static readonly RacialType MagicalBeast = new(19);
        public static readonly RacialType Outsider = new(20);
        public static readonly RacialType Shapechanger = new(23);
        public static readonly RacialType Undead = new(24);
        public static readonly RacialType Vermin = new(25);
        public static readonly RacialType All = new(28);
        public static readonly RacialType Invalid = new(28);
        public static readonly RacialType Ooze = new(29);
        public static readonly RacialType Plant = new(52);

        public RacialType(int internalValue) : base(internalValue)
        {
        }
    }
}