namespace NWN.Framework.Lite.Enum
{
    public class ProjectilePathType : NWEnumBase<int>
    {
        public static readonly ProjectilePathType Default = new(1);
        public static readonly ProjectilePathType Homing = new(1);
        public static readonly ProjectilePathType Ballistic = new(2);
        public static readonly ProjectilePathType HighBallistic = new(3);
        public static readonly ProjectilePathType Accelerating = new(4);

        public ProjectilePathType(int internalValue) : base(internalValue) { }
    }
}