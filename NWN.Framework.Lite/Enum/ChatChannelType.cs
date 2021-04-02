namespace NWN.Framework.Lite.Enum
{
    public class ChatChannelType: NWEnumBase<int>
    {
        public static readonly ChatChannelType PlayerTalk = new(1);
        public static readonly ChatChannelType PlayerShout = new(2);
        public static readonly ChatChannelType PlayerWhisper = new(3);
        public static readonly ChatChannelType PlayerTell = new(4);
        public static readonly ChatChannelType ServerMessage = new(5);
        public static readonly ChatChannelType PlayerParty = new(6);
        public static readonly ChatChannelType PlayerDM = new(14);
        public static readonly ChatChannelType DMTalk = new(17);
        public static readonly ChatChannelType DMShout = new(18);
        public static readonly ChatChannelType DMWhisper = new(19);
        public static readonly ChatChannelType DMTell = new(20);
        public static readonly ChatChannelType DMParty = new(22);
        public static readonly ChatChannelType DMDM = new(30);

        public ChatChannelType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator ChatChannelType(int internalValue) => new(internalValue);
    }
}