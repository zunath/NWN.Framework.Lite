namespace NWN.Framework.Lite.Enum
{
    public class DayNightCycleType: NWEnumBase<int>
    {
        public static readonly DayNightCycleType CycleDayNight = new(0);
        public static readonly DayNightCycleType AlwaysBright = new(1);
        public static readonly DayNightCycleType AlwaysDark = new(2);

        public DayNightCycleType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator DayNightCycleType(int internalValue) => new(internalValue);
    }
}