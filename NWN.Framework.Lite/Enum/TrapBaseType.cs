namespace NWN.Framework.Lite.Enum
{
    public class TrapBaseType
    {
        public static readonly TrapBaseType MinorSpike = new(0);
        public static readonly TrapBaseType AverageSpike = new(1);
        public static readonly TrapBaseType StrongSpike = new(2);
        public static readonly TrapBaseType DeadlySpike = new(3);
        public static readonly TrapBaseType MinorHoly = new(4);
        public static readonly TrapBaseType AverageHoly = new(5);
        public static readonly TrapBaseType StrongHoly = new(6);
        public static readonly TrapBaseType DeadlyHoly = new(7);
        public static readonly TrapBaseType MinorTangle = new(8);
        public static readonly TrapBaseType AverageTangle = new(9);
        public static readonly TrapBaseType StrongTangle = new(10);
        public static readonly TrapBaseType DeadlyTangle = new(11);
        public static readonly TrapBaseType MinorAcid = new(12);
        public static readonly TrapBaseType AverageAcid = new(13);
        public static readonly TrapBaseType StrongAcid = new(14);
        public static readonly TrapBaseType DeadlyAcid = new(15);
        public static readonly TrapBaseType MinorFire = new(16);
        public static readonly TrapBaseType AverageFire = new(17);
        public static readonly TrapBaseType StrongFire = new(18);
        public static readonly TrapBaseType DeadlyFire = new(19);
        public static readonly TrapBaseType MinorElectrical = new(20);
        public static readonly TrapBaseType AverageElectrical = new(21);
        public static readonly TrapBaseType StrongElectrical = new(22);
        public static readonly TrapBaseType DeadlyElectrical = new(23);
        public static readonly TrapBaseType MinorGas = new(24);
        public static readonly TrapBaseType AverageGas = new(25);
        public static readonly TrapBaseType StrongGas = new(26);
        public static readonly TrapBaseType DeadlyGas = new(27);
        public static readonly TrapBaseType MinorFrost = new(28);
        public static readonly TrapBaseType AverageFrost = new(29);
        public static readonly TrapBaseType StrongFrost = new(30);
        public static readonly TrapBaseType DeadlyFrost = new(31);
        public static readonly TrapBaseType MinorNegative = new(32);
        public static readonly TrapBaseType AverageNegative = new(33);
        public static readonly TrapBaseType StrongNegative = new(34);
        public static readonly TrapBaseType DeadlyNegative = new(35);
        public static readonly TrapBaseType MinorSonic = new(36);
        public static readonly TrapBaseType AverageSonic = new(37);
        public static readonly TrapBaseType StrongSonic = new(38);
        public static readonly TrapBaseType DeadlySonic = new(39);
        public static readonly TrapBaseType MinorAcidSplash = new(40);
        public static readonly TrapBaseType AverageAcidSplash = new(41);
        public static readonly TrapBaseType StrongAcidSplash = new(42);
        public static readonly TrapBaseType DeadlyAcidSplash = new(43);
        public static readonly TrapBaseType EpicElectrical = new(44);
        public static readonly TrapBaseType EpicFire = new(45);
        public static readonly TrapBaseType EpicFrost = new(46);
        public static readonly TrapBaseType EpicSonic = new(47);

        public int InternalValue { get; protected set; }

        public TrapBaseType(int internalValue) => InternalValue = internalValue;
    }
}
