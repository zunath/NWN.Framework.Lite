namespace NWN.Framework.Lite.Enum
{
    public class WeatherEffectType
    {
        public static readonly WeatherEffectType Rain = new(0);
        public static readonly WeatherEffectType Snow = new(0);
        public static readonly WeatherEffectType Lightning = new(0);

        public int InternalValue { get; protected set; }

        public WeatherEffectType(int internalValue) => InternalValue = internalValue;
    }
}