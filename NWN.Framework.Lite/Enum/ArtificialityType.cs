namespace NWN.Framework.Lite.Enum
{
    public class ArtificialityType: NWEnumBase<int>
    {
        public static readonly ArtificialityType Artificial = new(0);
        public static readonly ArtificialityType Natural = new(1);

        public ArtificialityType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ArtificialityType(int internalValue) => new(internalValue);
    }
}