namespace NWN.Framework.Lite.Enum
{
    public class ClericDomainType: NWEnumBase<int>
    {
        public static readonly ClericDomainType Air = new(0);
        public static readonly ClericDomainType Animal = new(1);
        public static readonly ClericDomainType Death = new(3);
        public static readonly ClericDomainType Destruction = new(4);
        public static readonly ClericDomainType Earth = new(5);
        public static readonly ClericDomainType Evil = new(6);
        public static readonly ClericDomainType Fire = new(7);
        public static readonly ClericDomainType Good = new(8);
        public static readonly ClericDomainType Healing = new(9);
        public static readonly ClericDomainType Knowledge = new(10);
        public static readonly ClericDomainType Magic = new(13);
        public static readonly ClericDomainType Plant = new(14);
        public static readonly ClericDomainType Protection = new(15);
        public static readonly ClericDomainType Strength = new(16);
        public static readonly ClericDomainType Sun = new(17);
        public static readonly ClericDomainType Travel = new(18);
        public static readonly ClericDomainType Trickery = new(19);
        public static readonly ClericDomainType War = new(20);
        public static readonly ClericDomainType Water = new(21);

        public ClericDomainType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ClericDomainType(int internalValue) => new(internalValue);
    }
}