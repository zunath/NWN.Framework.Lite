namespace NWN.Framework.Lite.Enum
{
    public class InvisibilityType: NWEnumBase<int>
    {
        public static readonly InvisibilityType Darkness = new(2);
        public static readonly InvisibilityType Improved = new(4);
        public static readonly InvisibilityType Normal = new(1);

        public InvisibilityType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator InvisibilityType(int internalValue) => new(internalValue);
    }
}
