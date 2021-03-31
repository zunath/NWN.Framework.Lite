namespace NWN.Framework.Lite.Enum
{
    public class TouchAttackReturnType
    {
        public static readonly TouchAttackReturnType Miss = new(0);
        public static readonly TouchAttackReturnType Hit = new(1);
        public static readonly TouchAttackReturnType Critical = new(2);

        public int InternalValue { get; protected set; }

        public TouchAttackReturnType(int internalValue) => InternalValue = internalValue;
    }
}
