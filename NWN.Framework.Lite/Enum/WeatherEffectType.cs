namespace NWN.Framework.Lite.Enum
{
    public class WeatherEffectType: NWEnumBase<int>
    {
        public static readonly WeatherEffectType Rain = new(0);
        public static readonly WeatherEffectType Snow = new(0);
        public static readonly WeatherEffectType Lightning = new(0);

        public WeatherEffectType(int internalValue) : base(internalValue)
        {
        }
    }
}