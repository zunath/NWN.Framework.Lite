namespace NWN.Framework.Lite.Enum
{
    public class PolymorphType : NWEnumBase<int>
    {
        public static readonly PolymorphType Werewolf = new(0);
        public static readonly PolymorphType Wererat = new(1);
        public static readonly PolymorphType Werecat = new(2);
        public static readonly PolymorphType GiantSpider = new(3);
        public static readonly PolymorphType Troll = new(4);
        public static readonly PolymorphType UmberHulk = new(5);
        public static readonly PolymorphType Pixie = new(6);
        public static readonly PolymorphType Zombie = new(7);
        public static readonly PolymorphType RedDragon = new(8);
        public static readonly PolymorphType FireGiant = new(9);
        public static readonly PolymorphType Balor = new(10);
        public static readonly PolymorphType DeathSlaad = new(10);
        public static readonly PolymorphType IronGolem = new(11);
        public static readonly PolymorphType HugeFireElemental = new(12);
        public static readonly PolymorphType HugeWaterElemental = new(13);
        public static readonly PolymorphType HugeEarthElemental = new(14);
        public static readonly PolymorphType HugeAirElemental = new(15);
        public static readonly PolymorphType ElderFireElemental = new(16);
        public static readonly PolymorphType ElderWaterElemental = new(17);
        public static readonly PolymorphType ElderEarthElemental = new(18);
        public static readonly PolymorphType ElderAirElemental = new(19);
        public static readonly PolymorphType BrownBear = new(20);
        public static readonly PolymorphType Panther = new(21);
        public static readonly PolymorphType Wolf = new(22);
        public static readonly PolymorphType Boar = new(23);
        public static readonly PolymorphType Badger = new(24);
        public static readonly PolymorphType Penguin = new(25);
        public static readonly PolymorphType Cow = new(26);
        public static readonly PolymorphType DoomKnight = new(27);
        public static readonly PolymorphType Yuanti = new(28);
        public static readonly PolymorphType Imp = new(29);
        public static readonly PolymorphType Quasit = new(30);
        public static readonly PolymorphType Succubus = new(31);
        public static readonly PolymorphType DireBrownBear = new(32);
        public static readonly PolymorphType DirePanther = new(33);
        public static readonly PolymorphType DireWolf = new(34);
        public static readonly PolymorphType DireBoar = new(35);
        public static readonly PolymorphType DireBadger = new(36);
        public static readonly PolymorphType CelestialAvenger = new(37);
        public static readonly PolymorphType Vrock = new(38);
        public static readonly PolymorphType Chicken = new(39);
        public static readonly PolymorphType FrostGiantMale = new(40);
        public static readonly PolymorphType FrostGiantFemale = new(41);
        public static readonly PolymorphType Heurodis = new(42);
        public static readonly PolymorphType JnahGiantMale = new(43);
        public static readonly PolymorphType JnahGiantFemale = new(44);
        public static readonly PolymorphType WyrmlingWhite = new(45);
        public static readonly PolymorphType WyrmlingBlue = new(46);
        public static readonly PolymorphType WyrmlingRed = new(47);
        public static readonly PolymorphType WyrmlingGreen = new(48);
        public static readonly PolymorphType WyrmlingBlack = new(49);
        public static readonly PolymorphType GolemAutomaton = new(50);
        public static readonly PolymorphType Manticore = new(51);
        public static readonly PolymorphType MaleDrow = new(52);
        public static readonly PolymorphType Harpy = new(53);
        public static readonly PolymorphType Basilisk = new(54);
        public static readonly PolymorphType Drider = new(55);
        public static readonly PolymorphType Beholder = new(56);
        public static readonly PolymorphType Medusa = new(57);
        public static readonly PolymorphType Gargoyle = new(58);
        public static readonly PolymorphType Minotaur = new(59);
        public static readonly PolymorphType SuperChicken = new(60);
        public static readonly PolymorphType Mindflayer = new(61);
        public static readonly PolymorphType DireTiger = new(62);
        public static readonly PolymorphType FemaleDrow = new(63);
        public static readonly PolymorphType AncientBlueDragon = new(64);
        public static readonly PolymorphType AncientRedDragon = new(65);
        public static readonly PolymorphType AncientGreenDragon = new(66);
        public static readonly PolymorphType VampireMale = new(67);
        public static readonly PolymorphType RisenLord = new(68);
        public static readonly PolymorphType Spectre = new(69);
        public static readonly PolymorphType VampireFemale = new(70);
        public static readonly PolymorphType NullHuman = new(71);

        public PolymorphType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator PolymorphType(int internalValue) => new(internalValue);
    }
}
