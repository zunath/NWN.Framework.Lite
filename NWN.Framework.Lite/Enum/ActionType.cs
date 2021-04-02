namespace NWN.Framework.Lite.Enum
{
    public class ActionType
    {
        public static readonly ActionType AnimalEmpathy = new(16);
        public static readonly ActionType AttackObject = new(3);
        public static readonly ActionType CastSpell = new(4);
        public static readonly ActionType CloseDoor = new(6);
        public static readonly ActionType CounterSpell = new(31);
        public static readonly ActionType DialogObject = new(7);
        public static readonly ActionType DisableTrap = new(8);
        public static readonly ActionType DropItem = new(2);
        public static readonly ActionType ExamineTrap = new(11);
        public static readonly ActionType FlagTrap = new(10);
        public static readonly ActionType Follow = new(35);
        public static readonly ActionType Heal = new(33);
        public static readonly ActionType Invalid = new(65535);
        public static readonly ActionType ItemCastSpell = new(19);
        public static readonly ActionType KiDamage = new(41);
        public static readonly ActionType Lock = new(14);
        public static readonly ActionType MoveToPoint = new(0);
        public static readonly ActionType OpenDoor = new(5);
        public static readonly ActionType OpenLock = new(13);
        public static readonly ActionType PickPocket = new(34);
        public static readonly ActionType PickUpItem = new(1);
        public static readonly ActionType RandomWalk = new(43);
        public static readonly ActionType RecoverTrap = new(9);
        public static readonly ActionType Rest = new(17);
        public static readonly ActionType SetTrap = new(12);
        public static readonly ActionType Sit = new(37);
        public static readonly ActionType SmiteGood = new(40);
        public static readonly ActionType Taunt = new(18);
        public static readonly ActionType UseObject = new(15);
        public static readonly ActionType Wait = new(36);

        public int InternalValue { get; protected set; }

        public ActionType(int internalValue)
        {
            InternalValue = internalValue;
        }

        public static explicit operator ActionType(int internalValue) => new(internalValue);
    }
}
