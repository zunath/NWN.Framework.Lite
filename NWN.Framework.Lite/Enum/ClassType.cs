namespace NWN.Framework.Lite.Enum
{
    public class ClassType: NWEnumBase<int>
    {
        public static readonly ClassType Barbarian = new(0);
        public static readonly ClassType Bard = new(1);
        public static readonly ClassType Cleric = new(2);
        public static readonly ClassType Druid = new(3);
        public static readonly ClassType Fighter = new(4);
        public static readonly ClassType Monk = new(5);
        public static readonly ClassType Paladin = new(6);
        public static readonly ClassType Ranger = new(7);
        public static readonly ClassType Rogue = new(8);
        public static readonly ClassType Sorcerer = new(9);
        public static readonly ClassType Wizard = new(10);
        public static readonly ClassType Aberration = new(11);
        public static readonly ClassType Animal = new(12);
        public static readonly ClassType Construct = new(13);
        public static readonly ClassType Humanoid = new(14);
        public static readonly ClassType Monstrous = new(15);
        public static readonly ClassType Elemental = new(16);
        public static readonly ClassType Fey = new(17);
        public static readonly ClassType Dragon = new(18);
        public static readonly ClassType Undead = new(19);
        public static readonly ClassType Commoner = new(20);
        public static readonly ClassType Beast = new(21);
        public static readonly ClassType Giant = new(22);
        public static readonly ClassType MagicalBeast = new(23);
        public static readonly ClassType Outsider = new(24);
        public static readonly ClassType Shapechanger = new(25);
        public static readonly ClassType Vermin = new(26);
        public static readonly ClassType Shadowdancer = new(27);
        public static readonly ClassType Harper = new(28);
        public static readonly ClassType ArcaneArcher = new(29);
        public static readonly ClassType Assassin = new(30);
        public static readonly ClassType Blackguard = new(31);
        public static readonly ClassType DivineChampion = new(32);
        public static readonly ClassType WeaponMaster = new(33);
        public static readonly ClassType Palemaster = new(34);
        public static readonly ClassType Shifter = new(35);
        public static readonly ClassType DwarvenDefender = new(36);
        public static readonly ClassType DragonDisciple = new(37);
        public static readonly ClassType Ooze = new(38);
        public static readonly ClassType EyeOfGruumsh = new(39);
        public static readonly ClassType ShouDisciple = new(40);
        public static readonly ClassType PDK = new(41);
        public static readonly ClassType Standard = new(66);
        public static readonly ClassType ForceSensitive = new(67);
        public static readonly ClassType Invalid = new(255);

        public ClassType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ClassType(int internalValue) => new(internalValue);
    }
}