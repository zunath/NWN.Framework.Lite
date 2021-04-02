namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyDamageResistType: NWEnumBase<int>
    {
        public static readonly ItemPropertyDamageResistType DamageResist5 = new(1);
        public static readonly ItemPropertyDamageResistType DamageResist10 = new(2);
        public static readonly ItemPropertyDamageResistType DamageResist15 = new(3);
        public static readonly ItemPropertyDamageResistType DamageResist20 = new(4);
        public static readonly ItemPropertyDamageResistType DamageResist25 = new(5);
        public static readonly ItemPropertyDamageResistType DamageResist30 = new(6);
        public static readonly ItemPropertyDamageResistType DamageResist35 = new(7);
        public static readonly ItemPropertyDamageResistType DamageResist40 = new(8);
        public static readonly ItemPropertyDamageResistType DamageResist45 = new(9);
        public static readonly ItemPropertyDamageResistType DamageResist50 = new(10);

        public ItemPropertyDamageResistType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ItemPropertyDamageResistType(int internalValue) => new(internalValue);
    }
}