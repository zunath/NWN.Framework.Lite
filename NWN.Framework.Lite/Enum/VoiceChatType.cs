namespace NWN.Framework.Lite.Enum
{
    public class VoiceChatType
    {
        public static readonly VoiceChatType Attack = new(0);
        public static readonly VoiceChatType BadIdea = new(47);
        public static readonly VoiceChatType Battlecry1 = new(1);
        public static readonly VoiceChatType Battlecry2 = new(2);
        public static readonly VoiceChatType Battlecry3 = new(3);
        public static readonly VoiceChatType Bored = new(39);
        public static readonly VoiceChatType CanDo = new(29);
        public static readonly VoiceChatType CantDo = new(30);
        public static readonly VoiceChatType Cheer = new(44);
        public static readonly VoiceChatType Cuss = new(43);
        public static readonly VoiceChatType Death = new(18);
        public static readonly VoiceChatType Encumbered = new(32);
        public static readonly VoiceChatType Enemies = new(6);
        public static readonly VoiceChatType Flee = new(7);
        public static readonly VoiceChatType FollowMe = new(22);
        public static readonly VoiceChatType GAttack = new(11);
        public static readonly VoiceChatType GAttack2 = new(12);
        public static readonly VoiceChatType GAttack3 = new(13);
        public static readonly VoiceChatType Goodbye = new(40);
        public static readonly VoiceChatType GoodIdea = new(46);
        public static readonly VoiceChatType Group = new(24);
        public static readonly VoiceChatType GuardMe = new(9);
        public static readonly VoiceChatType HealMe = new(4);
        public static readonly VoiceChatType Hello = new(34);
        public static readonly VoiceChatType Help = new(5);
        public static readonly VoiceChatType Hide = new(28);
        public static readonly VoiceChatType Hold = new(10);
        public static readonly VoiceChatType Laugh = new(42);
        public static readonly VoiceChatType LookHere = new(23);
        public static readonly VoiceChatType MoveOver = new(25);
        public static readonly VoiceChatType NearDeath = new(17);
        public static readonly VoiceChatType No = new(36);
        public static readonly VoiceChatType Pain1 = new(14);
        public static readonly VoiceChatType Pain2 = new(15);
        public static readonly VoiceChatType Pain3 = new(16);
        public static readonly VoiceChatType Picklock = new(26);
        public static readonly VoiceChatType Poisoned = new(19);
        public static readonly VoiceChatType Rest = new(38);
        public static readonly VoiceChatType Search = new(27);
        public static readonly VoiceChatType Selected = new(33);
        public static readonly VoiceChatType SpellFailed = new(20);
        public static readonly VoiceChatType Stop = new(37);
        public static readonly VoiceChatType TalkToMe = new(45);
        public static readonly VoiceChatType TaskComplete = new(31);
        public static readonly VoiceChatType Taunt = new(8);
        public static readonly VoiceChatType Thanks = new(41);
        public static readonly VoiceChatType Threaten = new(48);
        public static readonly VoiceChatType WeaponSucks = new(21);
        public static readonly VoiceChatType Yes = new(35);
        public int InternalValue { get; protected set; }

        public VoiceChatType(int internalValue) => InternalValue = internalValue;
    }
}
