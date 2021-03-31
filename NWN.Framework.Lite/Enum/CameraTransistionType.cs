namespace NWN.Framework.Lite.Enum
{
    public class CameraTransitionType: NWEnumBase<int>
    {
        public static readonly CameraTransitionType Snap = new(0);
        public static readonly CameraTransitionType Crawl = new(2);
        public static readonly CameraTransitionType VerySlow = new(5);
        public static readonly CameraTransitionType Slow = new(20);
        public static readonly CameraTransitionType Medium = new(40);
        public static readonly CameraTransitionType Fast = new(70);
        public static readonly CameraTransitionType VeryFast = new(100);

        public CameraTransitionType(int internalValue) : base(internalValue)
        {
        }
    }
}