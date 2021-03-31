namespace NWN.Framework.Lite.Enum
{
    public class StandardFactionType : NWEnumBase<int>
    {
        public static readonly SubSkillType Hostile = new(0);
        public static readonly SubSkillType Commoner = new(1);
        public static readonly SubSkillType Merchant = new(2);
        public static readonly SubSkillType Defender = new(3);

        public StandardFactionType(int internalValue) : base(internalValue) { }
    }
}