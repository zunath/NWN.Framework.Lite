namespace NWN.Framework.Lite.Enum
{
    public class DirectionType: NWEnumBase<int>
    {
        public static readonly DirectionType East = new(0);
        public static readonly DirectionType North = new(90);
        public static readonly DirectionType West = new(180);
        public static readonly DirectionType South = new(270);
        public static readonly DirectionType NorthEast = new(45);
        public static readonly DirectionType NorthWest = new(135);
        public static readonly DirectionType SouthEast = new(315);
        public static readonly DirectionType SouthWest = new(225);

        public DirectionType(int internalValue) : base(internalValue)
        {
        }
    }
}