namespace NWN.Framework.Lite.Enum
{
    public class EncounterDifficultyType : NWEnumBase<int>
    {
        // These represent the row in the difficulty 2da, rather than
        // a difficulty value.
        public static readonly EncounterDifficultyType Default = new(-1);
        public static readonly EncounterDifficultyType VeryLow = new(0);
        public static readonly EncounterDifficultyType Low = new(1);
        public static readonly EncounterDifficultyType Medium = new(2);
        public static readonly EncounterDifficultyType High = new(3);
        public static readonly EncounterDifficultyType VeryHigh = new(4);

        public EncounterDifficultyType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator EncounterDifficultyType(int internalValue) => new(internalValue);
    }
}