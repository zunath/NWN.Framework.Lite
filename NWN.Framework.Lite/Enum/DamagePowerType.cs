namespace NWN.Framework.Lite.Enum
{
    public class DamagePowerType: NWEnumBase<int>
    {
        public static readonly DamagePowerType Normal = new(0);
        public static readonly DamagePowerType PlusOne = new(1);
        public static readonly DamagePowerType PlusTwo = new(2);
        public static readonly DamagePowerType PlusThree = new(3);
        public static readonly DamagePowerType PlusFour = new(4);
        public static readonly DamagePowerType PlusFive = new(5);
        public static readonly DamagePowerType Energy = new(6);
        public static readonly DamagePowerType PlusSix = new(7);
        public static readonly DamagePowerType PlusSeven = new(8);
        public static readonly DamagePowerType PlusEight = new(9);
        public static readonly DamagePowerType PlusNine = new(10);
        public static readonly DamagePowerType PlusTen = new(11);
        public static readonly DamagePowerType PlusEleven = new(12);
        public static readonly DamagePowerType PlusTwelve = new(13);
        public static readonly DamagePowerType PlusThirteen = new(14);
        public static readonly DamagePowerType PlusFourteen = new(15);
        public static readonly DamagePowerType PlusFifteen = new(16);
        public static readonly DamagePowerType PlusSixteen = new(17);
        public static readonly DamagePowerType PlusSeventeen = new(18);
        public static readonly DamagePowerType PlusEighteen = new(19);
        public static readonly DamagePowerType PlusNineteen = new(20);
        public static readonly DamagePowerType PlusTwenty = new(21);

        public DamagePowerType(int internalValue) : base(internalValue)
        {
        }
    }
}