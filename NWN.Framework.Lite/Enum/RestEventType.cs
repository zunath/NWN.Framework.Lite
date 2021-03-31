namespace NWN.Framework.Lite.Enum
{
    public class RestEventType : NWEnumBase<int>
    {
        public static readonly RestEventType Invalid = new(0);
        public static readonly RestEventType Started = new(1);
        public static readonly RestEventType Finished = new(2);
        public static readonly RestEventType Cancelled = new(3);

        public RestEventType(int internalValue) : base(internalValue) { }
    }
}