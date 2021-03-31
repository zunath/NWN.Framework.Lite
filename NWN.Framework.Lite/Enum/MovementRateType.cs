namespace NWN.Framework.Lite.Enum
{
    public class MovementRateType : NWEnumBase<int>
    {
        public static readonly MovementRateType PC = new(0);
        public static readonly MovementRateType Immobile = new(1);
        public static readonly MovementRateType VerySlow = new(2);
        public static readonly MovementRateType Slow = new(3);
        public static readonly MovementRateType Normal = new(4);
        public static readonly MovementRateType Fast = new(5);
        public static readonly MovementRateType VeryFast = new(6);
        public static readonly MovementRateType Default = new(7);
        public static readonly MovementRateType DMFast = new(8);

        public MovementRateType(int internalValue) : base(internalValue) { }
    }
}