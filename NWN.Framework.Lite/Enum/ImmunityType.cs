namespace NWN.Framework.Lite.Enum
{
    public class ImmunityType: NWEnumBase<int>
    {
        public static readonly ImmunityType None = new(0);
        public static readonly ImmunityType MindSpells = new(1);
        public static readonly ImmunityType Poison = new(2);
        public static readonly ImmunityType Disease = new(3);
        public static readonly ImmunityType Fear = new(4);
        public static readonly ImmunityType Trap = new(5);
        public static readonly ImmunityType Paralysis = new(6);
        public static readonly ImmunityType Blindness = new(7);
        public static readonly ImmunityType Deafness = new(8);
        public static readonly ImmunityType Slow = new(9);
        public static readonly ImmunityType Entangle = new(10);
        public static readonly ImmunityType Silence = new(11);
        public static readonly ImmunityType Stun = new(12);
        public static readonly ImmunityType Sleep = new(13);
        public static readonly ImmunityType Charm = new(14);
        public static readonly ImmunityType Dominate = new(15);
        public static readonly ImmunityType Confused = new(16);
        public static readonly ImmunityType Cursed = new(17);
        public static readonly ImmunityType Dazed = new(18);
        public static readonly ImmunityType AbilityDecrease = new(19);
        public static readonly ImmunityType AttackDecrease = new(20);
        public static readonly ImmunityType DamageDecrease = new(21);
        public static readonly ImmunityType DamageImmunityDecrease = new(22);
        public static readonly ImmunityType AcDecrease = new(23);
        public static readonly ImmunityType MovementSpeedDecrease = new(24);
        public static readonly ImmunityType SavingThrowDecrease = new(25);
        public static readonly ImmunityType SpellResistanceDecrease = new(26);
        public static readonly ImmunityType SkillDecrease = new(27);
        public static readonly ImmunityType Knockdown = new(28);
        public static readonly ImmunityType NegativeLevel = new(29);
        public static readonly ImmunityType SneakAttack = new(30);
        public static readonly ImmunityType CriticalHit = new(31);
        public static readonly ImmunityType Death = new(32);

        public ImmunityType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ImmunityType(int internalValue) => new(internalValue);
    }
}