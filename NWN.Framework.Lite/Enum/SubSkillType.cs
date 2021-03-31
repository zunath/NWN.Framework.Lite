namespace NWN.Framework.Lite.Enum
{
    public class SubSkillType : NWEnumBase<int>
    {
        public static readonly SubSkillType None = new(0);
        public static readonly SubSkillType FlagTrap = new(100);
        public static readonly SubSkillType RecoverTrap = new(101);
        public static readonly SubSkillType ExamineTrap = new(102);

        public SubSkillType(int internalValue) : base(internalValue) { }
    }
}
