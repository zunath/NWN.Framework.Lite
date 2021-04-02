namespace NWN.Framework.Lite.Enum
{
    public class SavingThrowType : NWEnumBase<int>
    {
        public static readonly SavingThrowType All = new(0);
        public static readonly SavingThrowType None = new(0);
        public static readonly SavingThrowType MindSpells = new(1);
        public static readonly SavingThrowType Poison = new(2);
        public static readonly SavingThrowType Disease = new(3);
        public static readonly SavingThrowType Fear = new(4);
        public static readonly SavingThrowType Sonic = new(5);
        public static readonly SavingThrowType Acid = new(6);
        public static readonly SavingThrowType Fire = new(7);
        public static readonly SavingThrowType Electricity = new(8);
        public static readonly SavingThrowType Positive = new(9);
        public static readonly SavingThrowType Negative = new(10);
        public static readonly SavingThrowType Death = new(11);
        public static readonly SavingThrowType Cold = new(12);
        public static readonly SavingThrowType Divine = new(13);
        public static readonly SavingThrowType Trap = new(14);
        public static readonly SavingThrowType Spell = new(15);
        public static readonly SavingThrowType Good = new(16);
        public static readonly SavingThrowType Evil = new(17);
        public static readonly SavingThrowType Law = new(18);
        public static readonly SavingThrowType Chaos = new(19);

        public SavingThrowType(int internalValue) : base(internalValue)
        {

        }

        public static explicit operator SavingThrowType(int internalValue) => new(internalValue);
    }
}