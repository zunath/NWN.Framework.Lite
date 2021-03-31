namespace NWN.Framework.Lite.Enum
{
    public class DisturbType: NWEnumBase<int>
    {
        public static readonly DisturbType Added = new(0);
        public static readonly DisturbType Removed = new(1);
        public static readonly DisturbType Stolen = new(2);

        public DisturbType(int internalValue) : base(internalValue)
        {
        }
    }
}