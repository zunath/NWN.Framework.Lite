namespace NWN.Framework.Lite.Enum
{
    public class GenderType: NWEnumBase<int>
    {
        public static readonly GenderType Male = new(0);
        public static readonly GenderType Female = new(1);
        public static readonly GenderType Both = new(2);
        public static readonly GenderType Other = new(3);
        public static readonly GenderType None = new(4);

        public GenderType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator GenderType(int internalValue) => new(internalValue);
    }
}