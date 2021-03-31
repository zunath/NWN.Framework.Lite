namespace NWN.Framework.Lite.Enum
{
    public class TalentType: NWEnumBase<int>
    {
        public static readonly TalentType Spell = new(0);
        public static readonly TalentType Feat = new(1);
        public static readonly TalentType Skill = new(2);

        public TalentType(int internalValue) : base(internalValue)
        {
        }
    }
}