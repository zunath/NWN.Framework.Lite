namespace NWN.Framework.Lite.Enum
{
    public class CreatureSizeType: NWEnumBase<int>
    {
        public static readonly CreatureSizeType Invalid = new(0);
        public static readonly CreatureSizeType Tiny = new(1);
        public static readonly CreatureSizeType Small = new(2);
        public static readonly CreatureSizeType Medium = new(3);
        public static readonly CreatureSizeType Large = new(4);
        public static readonly CreatureSizeType Huge = new(5);

        public CreatureSizeType(int internalValue) : base(internalValue)
        {
        }
    }
}