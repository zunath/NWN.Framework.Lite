namespace NWN.Framework.Lite.Enum
{
    public class FogType: NWEnumBase<int>
    {
        public static readonly FogType All = new(0);
        public static readonly FogType Sun = new(1);
        public static readonly FogType Moon = new(2);

        public FogType(int internalValue) : base(internalValue)
        {
        }
    }
}