namespace NWN.Framework.Lite.Enum
{
    public class TalkVolumeType
    {
        public static readonly TalkVolumeType Talk = new(0);
        public static readonly TalkVolumeType Whisper = new(1);
        public static readonly TalkVolumeType Shout = new(2);
        public static readonly TalkVolumeType SilentTalk = new(3);
        public static readonly TalkVolumeType SilentShout = new(4);
        public static readonly TalkVolumeType Party = new(5);
        public static readonly TalkVolumeType Tell = new(6);

        public int InternalValue { get; protected set; }

        public TalkVolumeType(int internalValue) => InternalValue = internalValue;
    }
}