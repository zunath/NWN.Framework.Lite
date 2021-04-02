namespace NWN.Framework.Lite.Enum
{
    public class CreatureWingType: NWEnumBase<int>
    {
        public static readonly CreatureWingType None = new(0);
        public static readonly CreatureWingType Demon = new(1);
        public static readonly CreatureWingType Angel = new(2);
        public static readonly CreatureWingType Bat = new(3);
        public static readonly CreatureWingType Dragon = new(4);
        public static readonly CreatureWingType Butterfly = new(5);
        public static readonly CreatureWingType Bird = new(6);

        public CreatureWingType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator CreatureWingType(int internalValue) => new(internalValue);
    }
}