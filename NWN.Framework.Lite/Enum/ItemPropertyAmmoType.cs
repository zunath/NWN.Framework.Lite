namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyAmmoType: NWEnumBase<int>
    {
        public static readonly ItemPropertyAmmoType Arrow = new(0);
        public static readonly ItemPropertyAmmoType Bolt = new(1);
        public static readonly ItemPropertyAmmoType Bullet = new(2);

        public ItemPropertyAmmoType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ItemPropertyAmmoType(int internalValue) => new(internalValue);
    }
}