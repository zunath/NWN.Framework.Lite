namespace NWN.Framework.Lite.Enum
{
    public class MetaMagicType : NWEnumBase<int>
    {
        public static readonly MetaMagicType None = new(0);
        public static readonly MetaMagicType Empower = new(1);
        public static readonly MetaMagicType Extend = new(2);
        public static readonly MetaMagicType Maximize = new(4);
        public static readonly MetaMagicType Quicken = new(8);
        public static readonly MetaMagicType Silent = new(16);
        public static readonly MetaMagicType Any = new(255);

        public MetaMagicType(int internalValue) : base(internalValue)
        {

        }

        public static explicit operator MetaMagicType(int internalValue) => new(internalValue);
    }
}