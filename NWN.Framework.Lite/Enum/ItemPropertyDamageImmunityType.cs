namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyDamageImmunityType: NWEnumBase<int>
    {
        public static readonly ItemPropertyDamageImmunityType FivePercent = new(1);
        public static readonly ItemPropertyDamageImmunityType TenPercent = new(2);
        public static readonly ItemPropertyDamageImmunityType TwentyFivePercent = new(3);
        public static readonly ItemPropertyDamageImmunityType FiftyPercent = new(4);
        public static readonly ItemPropertyDamageImmunityType SeventyFivePercent = new(5);
        public static readonly ItemPropertyDamageImmunityType NinetyPercent = new(6);
        public static readonly ItemPropertyDamageImmunityType OneHundredPercent = new(7);

        public ItemPropertyDamageImmunityType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ItemPropertyDamageImmunityType(int internalValue) => new(internalValue);
    }
}