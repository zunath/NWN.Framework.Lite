namespace NWN.Framework.Lite.Enum
{
    public class GroundType
    {
        public static readonly GroundType UnderGround = new(0);
        public static readonly GroundType AboveGround = new(1);

        public int InternalValue { get; protected set; }

        public GroundType(int internalValue)
        {
            InternalValue = internalValue;
        }

        public static explicit operator GroundType(int internalValue) => new(internalValue);
    }
}