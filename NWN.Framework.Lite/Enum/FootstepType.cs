namespace NWN.Framework.Lite.Enum
{
    public class FootstepType: NWEnumBase<int>
    {
        // these constants must match those in the FootstepSounds.2da
        public static readonly FootstepType Invalid = new(-1);
        public static readonly FootstepType Normal = new(0);
        public static readonly FootstepType Large = new(1);
        public static readonly FootstepType Dragon = new(2);
        public static readonly FootstepType Soft = new(3);
        public static readonly FootstepType Hoof = new(4);
        public static readonly FootstepType HoofLarge = new(5);
        public static readonly FootstepType Beetle = new(6);
        public static readonly FootstepType Spider = new(7);
        public static readonly FootstepType Skeleton = new(8);
        public static readonly FootstepType LeatherWing = new(9);
        public static readonly FootstepType FeatherWing = new(10);
        public static readonly FootstepType None = new(12);
        public static readonly FootstepType Seagull = new(13);
        public static readonly FootstepType Shark = new(14);
        public static readonly FootstepType WaterNormal = new(15);
        public static readonly FootstepType WaterLarge = new(16);
        public static readonly FootstepType Horse = new(17);
        public static readonly FootstepType Default = new(65535);

        public FootstepType(int internalValue) : base(internalValue)
        {
        }
    }
}