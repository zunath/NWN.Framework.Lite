namespace NWN.Framework.Lite.Enum
{
    public class PoisonType: NWEnumBase<int>
    {
        // these constants must match those in poison.2da
        public static readonly PoisonType Nightshade = new(0);
        public static readonly PoisonType SmallCentipedePoison = new(1);
        public static readonly PoisonType BladeBane = new(2);
        public static readonly PoisonType GreenbloodOil = new(3);
        public static readonly PoisonType Bloodroot = new(4);
        public static readonly PoisonType PurpleWormPoison = new(5);
        public static readonly PoisonType LargeScorpionVenom = new(6);
        public static readonly PoisonType WyvernPoison = new(7);
        public static readonly PoisonType BlueWhinnis = new(8);
        public static readonly PoisonType GiantWaspPoison = new(9);
        public static readonly PoisonType ShadowEssence = new(10);
        public static readonly PoisonType BlackAdderVenom = new(11);
        public static readonly PoisonType Deathblade = new(12);
        public static readonly PoisonType MalyssRootPaste = new(13);
        public static readonly PoisonType Nitharit = new(14);
        public static readonly PoisonType DragonBile = new(15);
        public static readonly PoisonType SassoneLeafResidue = new(16);
        public static readonly PoisonType TerinavRoot = new(17);
        public static readonly PoisonType CarrionCrawlerBrainJuice = new(18);
        public static readonly PoisonType BlackLotusExtract = new(19);
        public static readonly PoisonType OilOfTaggit = new(20);
        public static readonly PoisonType IdMoss = new(21);
        public static readonly PoisonType StripedToadstool = new(22);
        public static readonly PoisonType Arsenic = new(23);
        public static readonly PoisonType LichDust = new(24);
        public static readonly PoisonType DarkReaverPowder = new(25);
        public static readonly PoisonType UngolDust = new(26);
        public static readonly PoisonType BurntOthurFumes = new(27);
        public static readonly PoisonType ChaosMist = new(28);
        public static readonly PoisonType BebilithVenom = new(29);
        public static readonly PoisonType QuasitVenom = new(30);
        public static readonly PoisonType PitFiendIchor = new(31);
        public static readonly PoisonType EttercapVenom = new(32);
        public static readonly PoisonType AraneaVenom = new(33);
        public static readonly PoisonType TinySpiderVenom = new(34);
        public static readonly PoisonType SmallSpiderVenom = new(35);
        public static readonly PoisonType MediumSpiderVenom = new(36);
        public static readonly PoisonType LargeSpiderVenom = new(37);
        public static readonly PoisonType HugeSpiderVenom = new(38);
        public static readonly PoisonType GargantuanSpiderVenom = new(39);
        public static readonly PoisonType ColossalSpiderVenom = new(40);
        public static readonly PoisonType PhaseSpiderVenom = new(41);
        public static readonly PoisonType WraithSpiderVenom = new(42);
        public static readonly PoisonType IronGolem = new(43);

        public PoisonType(int internalValue) : base(internalValue)
        {
        }
    }
}