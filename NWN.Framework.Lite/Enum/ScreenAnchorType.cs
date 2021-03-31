namespace NWN.Framework.Lite.Enum
{
    public class ScreenAnchorType : NWEnumBase<int>
    {
        public static readonly ScreenAnchorType TopLeft = new(0);
        public static readonly ScreenAnchorType TopRight = new(1);
        public static readonly ScreenAnchorType BottomLeft = new(2);
        public static readonly ScreenAnchorType BottomRight = new(3);
        public static readonly ScreenAnchorType Center = new(4);

        public ScreenAnchorType(int internalValue) : base(internalValue) { }
    }
}