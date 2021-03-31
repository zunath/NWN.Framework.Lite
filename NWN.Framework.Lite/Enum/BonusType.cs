namespace NWN.Framework.Lite.Enum
{
    public class BonusType: NWEnumBase<int>
    {
        public static readonly BonusType Attack = new(1);
        public static readonly BonusType Damage = new(2);
        public static readonly BonusType SavingThrow = new(3);
        public static readonly BonusType Ability = new(4);
        public static readonly BonusType Skill = new(5);
        public static readonly BonusType TouchAttack = new(6);

        public BonusType(int internalValue) : base(internalValue)
        {
        }
    }
}