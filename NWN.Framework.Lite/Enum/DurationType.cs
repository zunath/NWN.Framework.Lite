namespace NWN.Framework.Lite.Enum
{
    public class DurationType: NWEnumBase<int>
    {
        //Effect type constants
        public static readonly DurationType Invalid = new(-1);
        public static readonly DurationType Instant = new(0);
        public static readonly DurationType Temporary = new(1);
        public static readonly DurationType Permanent = new(2);

        public DurationType(int internalValue) : base(internalValue)
        {
        }
    }
}