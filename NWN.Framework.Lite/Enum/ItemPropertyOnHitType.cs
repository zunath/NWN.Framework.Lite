namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyOnHitType: NWEnumBase<int>
    {
        public static readonly ItemPropertyOnHitType Sleep = new(0);
        public static readonly ItemPropertyOnHitType Stun = new(1);
        public static readonly ItemPropertyOnHitType Hold = new(2);
        public static readonly ItemPropertyOnHitType Confusion = new(3);
        public static readonly ItemPropertyOnHitType Daze = new(5);
        public static readonly ItemPropertyOnHitType Doom = new(6);
        public static readonly ItemPropertyOnHitType Fear = new(7);
        public static readonly ItemPropertyOnHitType Knock = new(8);
        public static readonly ItemPropertyOnHitType Slow = new(9);
        public static readonly ItemPropertyOnHitType LesserDispel = new(10);
        public static readonly ItemPropertyOnHitType DispelMagic = new(11);
        public static readonly ItemPropertyOnHitType GreaterDispel = new(12);
        public static readonly ItemPropertyOnHitType MordsDisjunction = new(13);
        public static readonly ItemPropertyOnHitType Silence = new(14);
        public static readonly ItemPropertyOnHitType Deafness = new(15);
        public static readonly ItemPropertyOnHitType Blindness = new(16);
        public static readonly ItemPropertyOnHitType LevelDrain = new(17);
        public static readonly ItemPropertyOnHitType AbilityDrain = new(18);
        public static readonly ItemPropertyOnHitType ItemPoison = new(19);
        public static readonly ItemPropertyOnHitType Disease = new(20);
        public static readonly ItemPropertyOnHitType SlayRace = new(21);
        public static readonly ItemPropertyOnHitType SlayAlignmentGroup = new(22);
        public static readonly ItemPropertyOnHitType SlayAlignment = new(23);
        public static readonly ItemPropertyOnHitType Vorpal = new(24);
        public static readonly ItemPropertyOnHitType Wounding = new(25);

        public ItemPropertyOnHitType(int internalValue) : base(internalValue)
        {
        }
    }
}