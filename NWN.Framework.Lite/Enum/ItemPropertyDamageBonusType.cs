namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyDamageBonusType: NWEnumBase<int>
    {
        public static readonly ItemPropertyDamageBonusType DamageBonus1 = new(1);
        public static readonly ItemPropertyDamageBonusType DamageBonus2 = new(2);
        public static readonly ItemPropertyDamageBonusType DamageBonus3 = new(3);
        public static readonly ItemPropertyDamageBonusType DamageBonus4 = new(4);
        public static readonly ItemPropertyDamageBonusType DamageBonus5 = new(5);
        public static readonly ItemPropertyDamageBonusType DamageBonus1d4 = new(6);
        public static readonly ItemPropertyDamageBonusType DamageBonus1d6 = new(7);
        public static readonly ItemPropertyDamageBonusType DamageBonus1d8 = new(8);
        public static readonly ItemPropertyDamageBonusType DamageBonus1d10 = new(9);
        public static readonly ItemPropertyDamageBonusType DamageBonus2d6 = new(10);
        public static readonly ItemPropertyDamageBonusType DamageBonus2d8 = new(11);
        public static readonly ItemPropertyDamageBonusType DamageBonus2d4 = new(12);
        public static readonly ItemPropertyDamageBonusType DamageBonus2d10 = new(13);
        public static readonly ItemPropertyDamageBonusType DamageBonus1d12 = new(14);
        public static readonly ItemPropertyDamageBonusType DamageBonus2d12 = new(15);
        public static readonly ItemPropertyDamageBonusType DamageBonus6 = new(16);
        public static readonly ItemPropertyDamageBonusType DamageBonus7 = new(17);
        public static readonly ItemPropertyDamageBonusType DamageBonus8 = new(18);
        public static readonly ItemPropertyDamageBonusType DamageBonus9 = new(19);
        public static readonly ItemPropertyDamageBonusType DamageBonus10 = new(20);

        public ItemPropertyDamageBonusType(int internalValue) : base(internalValue)
        {
        }
    }
}