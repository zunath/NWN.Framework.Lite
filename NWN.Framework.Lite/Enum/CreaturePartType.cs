namespace NWN.Framework.Lite.Enum
{
    public class CreaturePartType: NWEnumBase<int>
    {
        // these constants must match those in the CAPart.2da
        public static readonly CreaturePartType RightFoot = new(0);
        public static readonly CreaturePartType LeftFoot = new(1);
        public static readonly CreaturePartType RightShin = new(2);
        public static readonly CreaturePartType LeftShin = new(3);
        public static readonly CreaturePartType LeftThigh = new(4);
        public static readonly CreaturePartType RightThigh = new(5);
        public static readonly CreaturePartType Pelvis = new(6);
        public static readonly CreaturePartType Torso = new(7);
        public static readonly CreaturePartType Belt = new(8);
        public static readonly CreaturePartType Neck = new(9);
        public static readonly CreaturePartType RightForearm = new(10);
        public static readonly CreaturePartType LeftForearm = new(11);
        public static readonly CreaturePartType RightBicep = new(12);
        public static readonly CreaturePartType LeftBicep = new(13);
        public static readonly CreaturePartType RightShoulder = new(14);
        public static readonly CreaturePartType LeftShoulder = new(15);
        public static readonly CreaturePartType RightHand = new(16);
        public static readonly CreaturePartType LeftHand = new(17);
        public static readonly CreaturePartType Head = new(20);

        public CreaturePartType(int internalValue) : base(internalValue)
        {
        }
    }
}