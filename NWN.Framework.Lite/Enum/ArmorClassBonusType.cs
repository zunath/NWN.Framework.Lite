namespace NWN.Framework.Lite.Enum
{
    public class ArmorClassBonusType: NWEnumBase<int>
    {
        public static ArmorClassBonusType Dodge = new(0);
        public static ArmorClassBonusType Natural = new(1);
        public static ArmorClassBonusType Armor = new(2);
        public static ArmorClassBonusType Shield = new(3);
        public static ArmorClassBonusType Deflection = new(4);

        public ArmorClassBonusType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ArmorClassBonusType(int internalValue) => new(internalValue);
    }
}