namespace NWN.Framework.Lite.Enum
{
    public class ACType
    {
        public static readonly ACType ArmorEnchantmentBonus = new(2);
        public static readonly ACType DeflectionBonus = new(4);
        public static readonly ACType DodgeBonus = new(0);
        public static readonly ACType NaturalBonus = new(1);
        public static readonly ACType ShieldEnchantmentBonus = new(3);
        public static readonly ACType VsDamageTypeAll = new(4103);


        public int InternalValue { get; protected set; }

        public ACType(int internalValue)
        {
            InternalValue = internalValue;
        }

    }
}
