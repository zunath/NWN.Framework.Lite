namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyOnMonsterHitType: NWEnumBase<int>
    {
        public static readonly ItemPropertyOnMonsterHitType AbilityDrain = new(0);
        public static readonly ItemPropertyOnMonsterHitType Confusion = new(1);
        public static readonly ItemPropertyOnMonsterHitType Disease = new(2);
        public static readonly ItemPropertyOnMonsterHitType Doom = new(3);
        public static readonly ItemPropertyOnMonsterHitType Fear = new(4);
        public static readonly ItemPropertyOnMonsterHitType LevelDrain = new(5);
        public static readonly ItemPropertyOnMonsterHitType Poison = new(6);
        public static readonly ItemPropertyOnMonsterHitType Slow = new(7);
        public static readonly ItemPropertyOnMonsterHitType Stun = new(8);
        public static readonly ItemPropertyOnMonsterHitType Wounding = new(9);

        public ItemPropertyOnMonsterHitType(int internalValue) : base(internalValue)
        {
        }
    }
}