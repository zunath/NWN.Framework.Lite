namespace NWN.Framework.Lite.Enum
{
    public class FadeSpeedType: NWEnumBase<float>
    {
        public static readonly FadeSpeedType Slowest = new (0.003f);
        public static readonly FadeSpeedType Slow = new(0.005f);
        public static readonly FadeSpeedType Medium = new(0.01f);
        public static readonly FadeSpeedType Fast = new (0.017f);
        public static readonly FadeSpeedType Fastest = new(0.25f);

        public FadeSpeedType(float internalValue) : base(internalValue)
        {
        }

        public static explicit operator FadeSpeedType(float internalValue) => new(internalValue);
    }
}