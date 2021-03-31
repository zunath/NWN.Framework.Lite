namespace NWN.Framework.Lite.Enum
{
    public class ShapeType : NWEnumBase<int>
    {
        public static readonly ShapeType SpellCylinder = new(0);
        public static readonly ShapeType Cone = new(1);
        public static readonly ShapeType Cube = new(2);
        public static readonly ShapeType SpellCone = new(3);
        public static readonly ShapeType Sphere = new(4);

        public ShapeType(int internalValue) : base(internalValue) { }
    }
}