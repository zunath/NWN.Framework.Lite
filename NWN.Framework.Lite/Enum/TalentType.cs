namespace NWN.Framework.Lite.Enum
{
    public class TalentType
    {
        public static readonly TalentType Spell = new(0);
        public static readonly TalentType Feat = new(1);
        public static readonly TalentType Skill = new(2);

        public int InternalValue { get; protected set; }

        public TalentType(int internalValue) => InternalValue = internalValue;
    }
}