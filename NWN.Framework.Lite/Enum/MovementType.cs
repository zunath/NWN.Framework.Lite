namespace NWN.Framework.Lite.Enum
{
    public class MovementType : NWEnumBase<int>
    {
        public static readonly MovementType Stationary = new(0);
        public static readonly MovementType Walk = new(1);
        public static readonly MovementType Run = new(2);
        public static readonly MovementType Sidestep = new(3);
        public static readonly MovementType WalkBackwards = new(4);

        public MovementType(int internalValue) : base(internalValue) { }
    }
}