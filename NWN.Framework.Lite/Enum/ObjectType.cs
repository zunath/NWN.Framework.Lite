namespace NWN.Framework.Lite.Enum
{
    public class ObjectType : NWEnumBase<int>
    {
        public static readonly ObjectType Creature = new(1);
        public static readonly ObjectType Item = new(2);
        public static readonly ObjectType Trigger = new(4);
        public static readonly ObjectType Door = new(8);
        public static readonly ObjectType AreaOfEffect = new(16);
        public static readonly ObjectType Waypoint = new(32);
        public static readonly ObjectType Placeable = new(64);
        public static readonly ObjectType Player = new(69);
        public static readonly ObjectType Store = new(128);
        public static readonly ObjectType Encounter = new(256);
        public static readonly ObjectType Tile = new(512);
        public static readonly ObjectType All = new(32767);
        public static readonly ObjectType Invalid = new(32767);

        public ObjectType(int internalValue) : base(internalValue) { }
    }
}