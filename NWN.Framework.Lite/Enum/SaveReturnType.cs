namespace NWN.Framework.Lite.Enum
{
    public class SaveReturnType : NWEnumBase<int>
    {
        public static readonly SaveReturnType Failed = new(0);
        public static readonly SaveReturnType Success = new(1);
        public static readonly SaveReturnType Immune = new(2);

        public SaveReturnType(int internalValue) : base(internalValue) { }
    }
}