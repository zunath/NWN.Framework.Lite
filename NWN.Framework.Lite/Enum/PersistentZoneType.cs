namespace NWN.Framework.Lite.Enum
{
    // These are for GetFirstInPersistentObject() and GetNextInPersistentObject()
    public class PersistentZoneType : NWEnumBase<int>
    {
        public static readonly PersistentZoneType Active = new(0);
        public static readonly PersistentZoneType Follow = new(1);

        public PersistentZoneType(int internalValue) : base(internalValue)
        {

        }

        public static explicit operator PersistentZoneType(int internalValue) => new(internalValue);
    }
}