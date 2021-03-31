namespace NWN.Framework.Lite.Enum
{
    public class DamageType: NWEnumBase<int>
    {
        public static readonly DamageType Bludgeoning = new(1);
        public static readonly DamageType Piercing = new(2);
        public static readonly DamageType Slashing = new(4);
        public static readonly DamageType Magical = new(8);
        public static readonly DamageType Acid = new(16);
        public static readonly DamageType Cold = new(32);
        public static readonly DamageType Divine = new(64);
        public static readonly DamageType Electrical = new(128);
        public static readonly DamageType Fire = new(256);
        public static readonly DamageType Negative = new(512);
        public static readonly DamageType Positive = new(1024);
        public static readonly DamageType Sonic = new(2048);

        // The base weapon damage is the base damage delivered by the weapon before
        // any additional types of damage (e.g. fire) have been added.
        public static readonly DamageType BaseWeapon = new(4096);

        public DamageType(int internalValue) : base(internalValue)
        {
        }
    }
}