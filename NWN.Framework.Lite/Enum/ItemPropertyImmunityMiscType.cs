namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyImmunityMiscType: NWEnumBase<int>
    {
        public static readonly ItemPropertyImmunityMiscType Backstab = new(0);
        public static readonly ItemPropertyImmunityMiscType LevelAbilityDrain = new(1);
        public static readonly ItemPropertyImmunityMiscType Mindspells = new(2);
        public static readonly ItemPropertyImmunityMiscType Poison = new(3);
        public static readonly ItemPropertyImmunityMiscType Disease = new(4);
        public static readonly ItemPropertyImmunityMiscType Fear = new(5);
        public static readonly ItemPropertyImmunityMiscType Knockdown = new(6);
        public static readonly ItemPropertyImmunityMiscType Paralysis = new(7);
        public static readonly ItemPropertyImmunityMiscType CriticalHits = new(8);
        public static readonly ItemPropertyImmunityMiscType DeathMagic = new(9);

        public ItemPropertyImmunityMiscType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ItemPropertyImmunityMiscType(int internalValue) => new(internalValue);
    }
}