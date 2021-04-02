namespace NWN.Framework.Lite.Enum
{
    public class CreatureModelType: NWEnumBase<int>
    {
        public static readonly CreatureModelType None = new(0);
        public static readonly CreatureModelType Skin = new(1);
        public static readonly CreatureModelType Tattoo = new(2);
        public static readonly CreatureModelType Undead = new(255);

        public CreatureModelType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator CreatureModelType(int internalValue) => new(internalValue);
    }
}