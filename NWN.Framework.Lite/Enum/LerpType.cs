namespace NWN.Framework.Lite.Enum
{
    public class LerpType : NWEnumBase<int>
    {
        public static readonly LerpType None = new(0); // 1
        public static readonly LerpType Linear = new(1); // x
        public static readonly LerpType Smoothstep = new(2); // x * x * (3 - 2 * x)
        public static readonly LerpType InverseSmoothstep = new(3); // 0.5 - sin(asin(1.0 - 2.0 * x) / 3.0)
        public static readonly LerpType EaseIn = new(4); // (1 - cosf(x * M_PI * 0.5))
        public static readonly LerpType EaseOut = new(5); // sinf(x * M_PI * 0.5)
        public static readonly LerpType Quadratic = new(6); // x * x
        public static readonly LerpType SmootherStep = new(7); // (x * x * x * (x * (6.0 * x - 15.0) + 10.0))

        public LerpType(int internalValue) : base(internalValue) { }
    }
}
