namespace NWN.Framework.Lite.Enum
{
    public class CreatureTailType: NWEnumBase<int>
    {
        // these constants must match those in the TailModel.2da
        public static readonly CreatureTailType None = new(0);
        public static readonly CreatureTailType Lizard = new(1);
        public static readonly CreatureTailType Bone = new(2);
        public static readonly CreatureTailType Devil = new(3);

        public CreatureTailType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator CreatureTailType(int internalValue) => new(internalValue);
    }
}