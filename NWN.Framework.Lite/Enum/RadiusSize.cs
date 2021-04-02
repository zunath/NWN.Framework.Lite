namespace NWN.Framework.Lite.Enum
{
    public class RadiusSize: NWEnumBase<float>
    {
        public static readonly RadiusSize Colossal = new(10.0f);
        public static readonly RadiusSize Gargantuan = new(8.33f);
        public static readonly RadiusSize Huge = new(6.67f);
        public static readonly RadiusSize Large = new(5.0f);
        public static readonly RadiusSize Medium = new(3.33f);
        public static readonly RadiusSize Small = new(1.67f);

        public RadiusSize(float internalValue) : base(internalValue)
        {
        }

        public static explicit operator RadiusSize(float internalValue) => new(internalValue);
    }
}
