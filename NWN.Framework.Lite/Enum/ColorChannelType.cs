namespace NWN.Framework.Lite.Enum
{
    public class ColorChannelType: NWEnumBase<int>
    {
        public static readonly ColorChannelType Skin = new(0);
        public static readonly ColorChannelType Hair = new(1);
        public static readonly ColorChannelType Tattoo1 = new(2);
        public static readonly ColorChannelType Tattoo2 = new(3);

        public ColorChannelType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ColorChannelType(int internalValue) => new(internalValue);
    }
}