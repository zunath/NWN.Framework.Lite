namespace NWN.Framework.Lite.Enum
{
    public class ReputationType : NWEnumBase<int>
    {
        public static readonly ReputationType Enemy = new(1);
        public static readonly ReputationType Friend = new(0);
        public static readonly ReputationType Neutral = new(2);

        public ReputationType(int internalValue) : base(internalValue)
        {

        }

        public static explicit operator ReputationType(int internalValue) => new(internalValue);
    }
}
