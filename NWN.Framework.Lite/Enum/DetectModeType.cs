namespace NWN.Framework.Lite.Enum
{
    public class DetectModeType: NWEnumBase<int>
    {
        public static readonly DetectModeType Passive = new(0);
        public static readonly DetectModeType Active = new(1);

        public DetectModeType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator DetectModeType(int internalValue) => new(internalValue);
    }
}