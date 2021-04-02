namespace NWN.Framework.Lite.Enum
{
    public class ArmorClassType: NWEnumBase<int>
    {
        public static readonly ArmorClassType DodgeBonus = new(0);
        public static readonly ArmorClassType NaturalBonus = new(1);
        public static readonly ArmorClassType EnchantmentBonus = new(2);
        public static readonly ArmorClassType ShieldEnchantmentBonus = new(3);
        public static readonly ArmorClassType DeflectionBonus = new(4);

        public ArmorClassType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ArmorClassType(int internalValue) => new(internalValue);
    }
}