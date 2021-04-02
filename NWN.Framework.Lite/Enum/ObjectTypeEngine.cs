namespace NWN.Framework.Lite.Enum
{
    public class ObjectTypeEngine : NWEnumBase<int>
    {
        public static readonly ObjectTypeEngine Invalid = new(-1);
        public static readonly ObjectTypeEngine GUI = new(1);
        public static readonly ObjectTypeEngine Tile = new(2);
        public static readonly ObjectTypeEngine Module = new(3);
        public static readonly ObjectTypeEngine Area = new(4);
        public static readonly ObjectTypeEngine Creature = new(5);
        public static readonly ObjectTypeEngine Item = new(6);
        public static readonly ObjectTypeEngine Trigger = new(7);
        public static readonly ObjectTypeEngine Projectile = new(8);
        public static readonly ObjectTypeEngine Placeable = new(9);
        public static readonly ObjectTypeEngine Door = new(10);
        public static readonly ObjectTypeEngine AreaOfEffect = new(11);
        public static readonly ObjectTypeEngine Waypoint = new(12);
        public static readonly ObjectTypeEngine Encounter = new(13);
        public static readonly ObjectTypeEngine Store = new(14);
        public static readonly ObjectTypeEngine Portal = new(15);
        public static readonly ObjectTypeEngine Sound = new(16);

        public ObjectTypeEngine(int internalValue) : base(internalValue)
        {

        }

        public static explicit operator ObjectTypeEngine(int internalValue) => new(internalValue);
    }
}