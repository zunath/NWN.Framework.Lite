namespace NWN.Framework.Lite.Enum
{
    public class StealthModeType : NWEnumBase<int>
    {
        public static readonly StealthModeType Passive = new(0);
        public static readonly StealthModeType Active = new(1);

        public StealthModeType(int internalValue) : base(internalValue) { }
    }
}