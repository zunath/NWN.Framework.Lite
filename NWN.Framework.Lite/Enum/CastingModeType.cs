namespace NWN.Framework.Lite.Enum
{
    public class CastingModeType: NWEnumBase<int>
    {
        public static readonly CastingModeType Disabled = new(0);
        public static readonly CastingModeType Activated = new(1);

        public CastingModeType(int internalValue) : base(internalValue)
        {
        }
    }
}