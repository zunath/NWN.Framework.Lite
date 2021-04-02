namespace NWN.Framework.Lite.Enum
{
    public class AreaDimensionType
    {
        public static readonly AreaDimensionType Height = new(0);
        public static readonly AreaDimensionType Width = new(1);

        public int InternalValue { get; protected set; }

        public AreaDimensionType(int internalValue)
        {
            InternalValue = internalValue;
        }

        public static explicit operator AreaDimensionType(int internalValue) => new(internalValue);
    }
}