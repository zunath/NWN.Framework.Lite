namespace NWN.Framework.Lite.Enum
{
    public class AssociateType: NWEnumBase<int>
    {
        // These match the values in nwscreature.h
        public static readonly AssociateType None = new(0);
        public static readonly AssociateType Henchman = new(1);
        public static readonly AssociateType AnimalCompanion = new(2);
        public static readonly AssociateType Familiar = new(3);
        public static readonly AssociateType Summoned = new(4);
        public static readonly AssociateType Dominated = new(5);

        public AssociateType(int internalValue) : base(internalValue)
        {
        }
    }
}