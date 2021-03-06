namespace NWN.Framework.Lite.Enum
{
    public class TouchAttackReturnType: NWEnumBase<int>
    {
        public static readonly TouchAttackReturnType Miss = new(0);
        public static readonly TouchAttackReturnType Hit = new(1);
        public static readonly TouchAttackReturnType Critical = new(2);

        public TouchAttackReturnType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator TouchAttackReturnType(int internalValue) => new(internalValue);
    }
}
