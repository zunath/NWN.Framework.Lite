namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyPoisonOneDTwoType: NWEnumBase<int>
    {
        public static readonly ItemPropertyPoisonOneDTwoType StrengthDamage = new(0);
        public static readonly ItemPropertyPoisonOneDTwoType DexterityDamage = new(1);
        public static readonly ItemPropertyPoisonOneDTwoType ConstitutionDamage = new(2);
        public static readonly ItemPropertyPoisonOneDTwoType IntelligenceDamage = new(3);
        public static readonly ItemPropertyPoisonOneDTwoType WisdomDamage = new(4);
        public static readonly ItemPropertyPoisonOneDTwoType CharismaDamage = new(5);

        public ItemPropertyPoisonOneDTwoType(int internalValue) : base(internalValue)
        {
        }
    }
}