namespace NWN.Framework.Lite.Enum
{
    public class FogColorType: NWEnumBase<int>
    {
        public static readonly FogColorType Red = new(16711680);
        public static readonly FogColorType RedDark = new(6684672);
        public static readonly FogColorType Green = new(65280);
        public static readonly FogColorType GreenDark = new(23112);
        public static readonly FogColorType Blue = new(255);
        public static readonly FogColorType BlueDark = new(102);
        public static readonly FogColorType Black = new(0);
        public static readonly FogColorType White = new(16777215);
        public static readonly FogColorType Grey = new(10066329);
        public static readonly FogColorType Yellow = new(16776960);
        public static readonly FogColorType YellowDark = new(11184640);
        public static readonly FogColorType Cyan = new(65535);
        public static readonly FogColorType Magenta = new(16711935);
        public static readonly FogColorType Orange = new(16750848);
        public static readonly FogColorType OrangeDark = new(13395456);
        public static readonly FogColorType Brown = new(10053120);
        public static readonly FogColorType BrownDark = new(6697728);

        public FogColorType(int internalValue) : base(internalValue)
        {
        }
    }
}