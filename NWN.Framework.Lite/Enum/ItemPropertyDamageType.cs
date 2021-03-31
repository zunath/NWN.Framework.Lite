namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyDamageType: NWEnumBase<int>
    {
        public static readonly ItemPropertyDamageType Bludgeoning = new(0);
        public static readonly ItemPropertyDamageType Piercing = new(1);
        public static readonly ItemPropertyDamageType Slashing = new(2);
        public static readonly ItemPropertyDamageType Subdual = new(3);
        public static readonly ItemPropertyDamageType Physical = new(4);
        public static readonly ItemPropertyDamageType Magical = new(5);
        public static readonly ItemPropertyDamageType Acid = new(6);
        public static readonly ItemPropertyDamageType Cold = new(7);
        public static readonly ItemPropertyDamageType Divine = new(8);
        public static readonly ItemPropertyDamageType Electrical = new(9);
        public static readonly ItemPropertyDamageType Fire = new(10);
        public static readonly ItemPropertyDamageType Negative = new(11);
        public static readonly ItemPropertyDamageType Positive = new(12);
        public static readonly ItemPropertyDamageType Sonic = new(13);
        public static readonly ItemPropertyDamageType Ballistic = new(14);
        public static readonly ItemPropertyDamageType Energy = new(15);
        public static readonly ItemPropertyDamageType Bullet = new(16);

        public ItemPropertyDamageType(int internalValue) : base(internalValue)
        {
        }
    }
}