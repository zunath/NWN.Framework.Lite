namespace NWN.Framework.Lite.Enum
{
    public class MouseCursorType: NWEnumBase<int>
    {
        public static readonly MouseCursorType Invalid = new(-1);
        public static readonly MouseCursorType Default = new(1);
        public static readonly MouseCursorType DefaultDown = new(2);
        public static readonly MouseCursorType Walk = new(3);
        public static readonly MouseCursorType WalkDown = new(4);
        public static readonly MouseCursorType NoWalk = new(5);
        public static readonly MouseCursorType NoWalkDown = new(6);
        public static readonly MouseCursorType Attack = new(7);
        public static readonly MouseCursorType AttackDown = new(8);
        public static readonly MouseCursorType NoAttack = new(9);
        public static readonly MouseCursorType NoAttackDown = new(10);
        public static readonly MouseCursorType Talk = new(11);
        public static readonly MouseCursorType TalkDown = new(12);
        public static readonly MouseCursorType NoTalk = new(13);
        public static readonly MouseCursorType NoTalkDown = new(14);
        public static readonly MouseCursorType Follow = new(15);
        public static readonly MouseCursorType FollowDown = new(16);
        public static readonly MouseCursorType Examine = new(17);
        public static readonly MouseCursorType ExamineDown = new(18);
        public static readonly MouseCursorType NoExamine = new(19);
        public static readonly MouseCursorType NoExamineDown = new(20);
        public static readonly MouseCursorType Transition = new(21);
        public static readonly MouseCursorType TransitionDown = new(22);
        public static readonly MouseCursorType Door = new(23);
        public static readonly MouseCursorType DoorDown = new(24);
        public static readonly MouseCursorType Use = new(25);
        public static readonly MouseCursorType UseDown = new(26);
        public static readonly MouseCursorType Mouse = new(27);
        public static readonly MouseCursorType MouseDown = new(28);
        public static readonly MouseCursorType Magic = new(29);
        public static readonly MouseCursorType MagicDown = new(30);
        public static readonly MouseCursorType NoMagic = new(31);
        public static readonly MouseCursorType NoMagicDown = new(32);
        public static readonly MouseCursorType Disarm = new(33);
        public static readonly MouseCursorType DisarmDown = new(34);
        public static readonly MouseCursorType NoDisarm = new(35);
        public static readonly MouseCursorType NoDisarmDown = new(36);
        public static readonly MouseCursorType Action = new(37);
        public static readonly MouseCursorType ActionDown = new(38);
        public static readonly MouseCursorType NoAction = new(39);
        public static readonly MouseCursorType NoActionDown = new(40);
        public static readonly MouseCursorType Lock = new(41);
        public static readonly MouseCursorType LockDown = new(42);
        public static readonly MouseCursorType NoLock = new(43);
        public static readonly MouseCursorType NoLockDown = new(44);
        public static readonly MouseCursorType PushPin = new(45);
        public static readonly MouseCursorType PushPinDown = new(46);
        public static readonly MouseCursorType Create = new(47);
        public static readonly MouseCursorType CreateDown = new(48);
        public static readonly MouseCursorType NoCreate = new(49);
        public static readonly MouseCursorType NoCreateDown = new(50);
        public static readonly MouseCursorType Kill = new(51);
        public static readonly MouseCursorType KillDown = new(52);
        public static readonly MouseCursorType NoKill = new(53);
        public static readonly MouseCursorType NoKillDown = new(54);
        public static readonly MouseCursorType Heal = new(55);
        public static readonly MouseCursorType HealDown = new(56);
        public static readonly MouseCursorType NoHeal = new(57);
        public static readonly MouseCursorType NohealDown = new(58);
        public static readonly MouseCursorType RunArrow = new(59);
        public static readonly MouseCursorType WalkArrow = new(75);
        public static readonly MouseCursorType PickUp = new(91);
        public static readonly MouseCursorType PickUpDown = new(92);
        public static readonly MouseCursorType Custom00 = new(93);       // gui_mp_custom00u
        public static readonly MouseCursorType Custom00Down = new(94);  // gui_mp_custom00d

        // More custom mouse cursors can be added here.

        public static readonly MouseCursorType Custom99 = new(291);      // gui_mp_custom99u
        public static readonly MouseCursorType Custom99Down = new(292); // gui_mp_custom99d

        public MouseCursorType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator MouseCursorType(int internalValue) => new(internalValue);
    }
}
