namespace NWN.Framework.Lite.Enum
{
    public class AlignmentType
    {
        public static readonly AlignmentType All = new(0);
        public static readonly AlignmentType Neutral = new(1);
        public static readonly AlignmentType Lawful = new(2);
        public static readonly AlignmentType Chaotic = new(3);
        public static readonly AlignmentType Good = new(4);
        public static readonly AlignmentType Evil = new(5);

        public int InternalValue { get; protected set; }

        public AlignmentType(int internalValue)
        {
            InternalValue = internalValue;
        }

    }
}