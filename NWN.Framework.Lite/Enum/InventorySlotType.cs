namespace NWN.Framework.Lite.Enum
{
    public class InventorySlotType: NWEnumBase<int>
    {
        public static readonly InventorySlotType Invalid = new(-1);
        public static readonly InventorySlotType Head = new(0);
        public static readonly InventorySlotType Chest = new(1);
        public static readonly InventorySlotType Boots = new(2);
        public static readonly InventorySlotType Arms = new(3);
        public static readonly InventorySlotType RightHand = new(4);
        public static readonly InventorySlotType LeftHand = new(5);
        public static readonly InventorySlotType Cloak = new(6);
        public static readonly InventorySlotType LeftRing = new(7);
        public static readonly InventorySlotType RightRing = new(8);
        public static readonly InventorySlotType Neck = new(9);
        public static readonly InventorySlotType Belt = new(10);
        public static readonly InventorySlotType Arrows = new(11);
        public static readonly InventorySlotType Bullets = new(12);
        public static readonly InventorySlotType Bolts = new(13);
        public static readonly InventorySlotType CreatureLeft = new(14);
        public static readonly InventorySlotType CreatureRight = new(15);
        public static readonly InventorySlotType CreatureBite = new(16);
        public static readonly InventorySlotType CreatureArmor = new(17);

        public InventorySlotType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator InventorySlotType(int internalValue) => new(internalValue);
    }
}