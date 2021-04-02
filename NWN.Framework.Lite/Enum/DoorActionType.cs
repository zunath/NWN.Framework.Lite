namespace NWN.Framework.Lite.Enum
{
    public class DoorActionType: NWEnumBase<int>
    {
        public static readonly DoorActionType Open = new(0);
        public static readonly DoorActionType Unlock = new(1);
        public static readonly DoorActionType Bash = new(2);
        public static readonly DoorActionType Ignore = new(3);
        public static readonly DoorActionType Knock = new(4);

        public DoorActionType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator DoorActionType(int internalValue) => new(internalValue);
    }
}