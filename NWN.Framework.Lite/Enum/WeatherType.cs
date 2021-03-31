﻿namespace NWN.Framework.Lite.Enum
{
    public class WeatherType
    {
        public static readonly WeatherType Invalid = new(-1);
        public static readonly WeatherType Clear = new(0);
        public static readonly WeatherType Rain = new(1);
        public static readonly WeatherType Snow = new(2);
        public static readonly WeatherType Foggy = new(3);
        public static readonly WeatherType UseAreaSettings = new(-1);

        public int InternalValue { get; protected set; }

        public WeatherType(int internalValue) => InternalValue = internalValue;
    }
}