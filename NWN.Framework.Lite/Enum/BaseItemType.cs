namespace NWN.Framework.Lite.Enum
{
    public class BaseItemType : NWEnumBase<int>
    {
        public static readonly BaseItemType Invalid = new(-1);
        public static readonly BaseItemType ShortSword = new(0);
        public static readonly BaseItemType Longsword = new(1);
        public static readonly BaseItemType BattleAxe = new(2);
        public static readonly BaseItemType BastardSword = new(3);
        public static readonly BaseItemType LightFlail = new(4);
        public static readonly BaseItemType WarHammer = new(5);
        public static readonly BaseItemType Cannon = new(6);
        public static readonly BaseItemType HeavyCrossbow = new(7);
        public static readonly BaseItemType Longbow = new(8);
        public static readonly BaseItemType LightMace = new(9);
        public static readonly BaseItemType Halberd = new(10);
        public static readonly BaseItemType Shortbow = new(11);
        public static readonly BaseItemType TwoBladedSword = new(12);
        public static readonly BaseItemType GreatSword = new(13);
        public static readonly BaseItemType SmallShield = new(14);
        public static readonly BaseItemType Torch = new(15);
        public static readonly BaseItemType Armor = new(16);
        public static readonly BaseItemType Helmet = new(17);
        public static readonly BaseItemType GreatAxe = new(18);
        public static readonly BaseItemType Amulet = new(19);
        public static readonly BaseItemType Arrow = new(20);
        public static readonly BaseItemType Belt = new(21);
        public static readonly BaseItemType Dagger = new(22);
        public static readonly BaseItemType MiscSmall = new(24);
        public static readonly BaseItemType Bolt = new(25);
        public static readonly BaseItemType Boots = new(26);
        public static readonly BaseItemType Bullet = new(27);
        public static readonly BaseItemType Club = new(28);
        public static readonly BaseItemType MiscMedium = new(29);
        public static readonly BaseItemType Dart = new(31);
        public static readonly BaseItemType DireMace = new(32);
        public static readonly BaseItemType DoubleAxe = new(33);
        public static readonly BaseItemType MiscLarge = new(34);
        public static readonly BaseItemType HeavyFlail = new(35);
        public static readonly BaseItemType Gloves = new(36);
        public static readonly BaseItemType LightHammer = new(37);
        public static readonly BaseItemType HandAxe = new(38);
        public static readonly BaseItemType HealersKit = new(39);
        public static readonly BaseItemType Kama = new(40);
        public static readonly BaseItemType Katana = new(41);
        public static readonly BaseItemType Kukri = new(42);
        public static readonly BaseItemType MiscTall = new(43);
        public static readonly BaseItemType MagicRod = new(44);
        public static readonly BaseItemType MagicStaff = new(45);
        public static readonly BaseItemType MagicWand = new(46);
        public static readonly BaseItemType MorningStar = new(47);
        public static readonly BaseItemType Potions = new(49);
        public static readonly BaseItemType QuarterStaff = new(50);
        public static readonly BaseItemType Rapier = new(51);
        public static readonly BaseItemType Ring = new(52);
        public static readonly BaseItemType Scimitar = new(53);
        public static readonly BaseItemType Scroll = new(54);
        public static readonly BaseItemType Scythe = new(55);
        public static readonly BaseItemType LargeShield = new(56);
        public static readonly BaseItemType TowerShield = new(57);
        public static readonly BaseItemType ShortSpear = new(58);
        public static readonly BaseItemType Shuriken = new(59);
        public static readonly BaseItemType Sickle = new(60);
        public static readonly BaseItemType Sling = new(61);
        public static readonly BaseItemType ThievesTools = new(62);
        public static readonly BaseItemType ThrowingAxe = new(63);
        public static readonly BaseItemType TrapKit = new(64);
        public static readonly BaseItemType Key = new(65);
        public static readonly BaseItemType LargeBox = new(66);
        public static readonly BaseItemType MiscWide = new(68);
        public static readonly BaseItemType CreatureSlashWeapon = new(69);
        public static readonly BaseItemType CreaturePierceWeapon = new(70);
        public static readonly BaseItemType CreatureBludgeWeapon = new(71);
        public static readonly BaseItemType CreatureSlashPierceWeapon = new(72);
        public static readonly BaseItemType CreatureItem = new(73);
        public static readonly BaseItemType Book = new(74);
        public static readonly BaseItemType SpellScroll = new(75);
        public static readonly BaseItemType Gold = new(76);
        public static readonly BaseItemType Gem = new(77);
        public static readonly BaseItemType Bracer = new(78);
        public static readonly BaseItemType MiscThin = new(79);
        public static readonly BaseItemType Cloak = new(80);
        public static readonly BaseItemType Grenade = new(81);
        public static readonly BaseItemType Encampment = new(82);
        public static readonly BaseItemType Lance = new(92);
        public static readonly BaseItemType Trumpet = new(92);
        public static readonly BaseItemType MoonOnAStick = new(92);
        public static readonly BaseItemType Trident = new(95);
        public static readonly BaseItemType BlankPotion = new(101);
        public static readonly BaseItemType BlankScroll = new(102);
        public static readonly BaseItemType BlankWand = new(103);
        public static readonly BaseItemType EnchantedPotion = new(104);
        public static readonly BaseItemType EnchantedScroll = new(105);
        public static readonly BaseItemType EnchantedWand = new(106);
        public static readonly BaseItemType DwarvenWarAxe = new(108);
        public static readonly BaseItemType CraftMaterialMedium = new(109);
        public static readonly BaseItemType CraftMaterialSmall = new(110);
        public static readonly BaseItemType Whip = new(111);
        public static readonly BaseItemType CraftBase = new(112);

        public BaseItemType(int internalValue) : base(internalValue)
        {
        }
    }
}