namespace NWN.Framework.Lite.Enum
{
    public class ObjectVisualTransformType : NWEnumBase<int>
    {
        public static readonly ObjectVisualTransformType Scale = new(10);
        public static readonly ObjectVisualTransformType RotateX = new(21);
        public static readonly ObjectVisualTransformType RotateY = new(22);
        public static readonly ObjectVisualTransformType RotateZ = new(23);
        public static readonly ObjectVisualTransformType TranslateX = new(31);
        public static readonly ObjectVisualTransformType TranslateY = new(32);
        public static readonly ObjectVisualTransformType TranslateZ = new(33);
        public static readonly ObjectVisualTransformType AnimationSpeed = new(40);

        public ObjectVisualTransformType(int internalValue) : base(internalValue)
        {

        }

        public static explicit operator ObjectVisualTransformType(int internalValue) => new(internalValue);
    }
}