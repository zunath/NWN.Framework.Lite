namespace NWN.Framework.Lite.Enum
{
    public class ColorType: NWEnumBase<int>
    {
        public static readonly ColorType MoonAmbient = new(0);
        public static readonly ColorType MoonDiffuse = new(1);
        public static readonly ColorType SunAmbient = new(2);
        public static readonly ColorType SunDiffuse = new(3);

        public ColorType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ColorType(int internalValue) => new(internalValue);
    }
}