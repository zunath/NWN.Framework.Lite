namespace NWN.Framework.Lite.Enum
{
    public class RestType : NWEnumBase<int>
    {
        public static readonly RestType Invalid = new(0);
        public static readonly RestType Started = new(1);
        public static readonly RestType Finished = new(2);
        public static readonly RestType Cancelled = new(3);

        public RestType(int internalValue) : base(internalValue)
        {

        }

        public static explicit operator RestType(int internalValue) => new(internalValue);
    }
}