namespace NWN.Framework.Lite.Enum
{
    public class AttackBonusType:NWEnumBase<int>
    {
        public static readonly AttackBonusType Misc = new(0);
        public static readonly AttackBonusType OnHand = new(1);
        public static readonly AttackBonusType OffHand = new(2);

        public AttackBonusType(int internalValue) : base(internalValue)
        {
        }
    }
}