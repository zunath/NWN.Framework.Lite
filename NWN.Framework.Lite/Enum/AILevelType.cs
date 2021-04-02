namespace NWN.Framework.Lite.Enum
{
    public class AILevelType
    {
        public static readonly AILevelType Default = new(-1);
        public static readonly AILevelType VeryLow = new(0);
        public static readonly AILevelType Low = new(1);
        public static readonly AILevelType Medium = new(2);
        public static readonly AILevelType High = new(3);
        public static readonly AILevelType VeryHigh = new(4);

        public int InternalValue { get; protected set; }

        public AILevelType(int internalValue)
        {
            InternalValue = internalValue;
        }

        public static explicit operator AILevelType(int internalValue) => new(internalValue);
    }
}