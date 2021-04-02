namespace NWN.Framework.Lite.Enum
{
    public class PvPSettingType : NWEnumBase<int>
    {
        public static readonly PvPSettingType NoPvP = new(0);
        public static readonly PvPSettingType PartyPvP = new(1);
        public static readonly PvPSettingType FullPvP = new(2);
        public static readonly PvPSettingType ServerDefault = new(3);

        public PvPSettingType(int internalValue) : base(internalValue)
        {

        }

        public static explicit operator PvPSettingType(int internalValue) => new(internalValue);
    }
}