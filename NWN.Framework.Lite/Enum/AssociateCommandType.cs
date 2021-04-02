namespace NWN.Framework.Lite.Enum
{
    public class AssociateCommandType: NWEnumBase<int>
    {
        // These must match the values in nwscreature.h and nwccreaturemenu.cpp
        // Cannot use the value -1 because that is used to start a conversation
        public static readonly AssociateCommandType StandGround = new(-2);
        public static readonly AssociateCommandType AttackNearest = new(-3);
        public static readonly AssociateCommandType HealMaster = new(-4);
        public static readonly AssociateCommandType FollowMaster = new(-5);
        public static readonly AssociateCommandType MasterFailedLockpick = new(-6);
        public static readonly AssociateCommandType GuardMaster = new(-7);
        public static readonly AssociateCommandType UnsummonFamiliar = new(-8);
        public static readonly AssociateCommandType UnsummonAnimalCompanion = new(-9);
        public static readonly AssociateCommandType UnsummonSummoned = new(-10);
        public static readonly AssociateCommandType MasterUnderAttack = new(-11);
        public static readonly AssociateCommandType ReleaseDomination = new(-12);
        public static readonly AssociateCommandType UnpossessFamiliar = new(-13);
        public static readonly AssociateCommandType MasterSawTrap = new(-14);
        public static readonly AssociateCommandType MasterAttackedOther = new(-15);
        public static readonly AssociateCommandType MasterGoingtobeAttacked = new(-16);
        public static readonly AssociateCommandType LeaveParty = new(-17);
        public static readonly AssociateCommandType PickLock = new(-18);
        public static readonly AssociateCommandType Inventory = new(-19);
        public static readonly AssociateCommandType DisarmTrap = new(-20);
        public static readonly AssociateCommandType ToggleCasting = new(-21);
        public static readonly AssociateCommandType ToggleStealth = new(-22);
        public static readonly AssociateCommandType ToggleSearch = new(-23);

        public AssociateCommandType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator AssociateCommandType(int internalValue) => new(internalValue);
    }
}