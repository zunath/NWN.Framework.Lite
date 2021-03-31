namespace NWN.Framework.Lite.Enum
{
    public class BodyNodeType: NWEnumBase<int>
    {
        public static readonly BodyNodeType Chest = new(1);
        public static readonly BodyNodeType Hand = new(0);
        public static readonly BodyNodeType Monster0 = new(2);
        public static readonly BodyNodeType Monster1 = new(3);
        public static readonly BodyNodeType Monster2 = new(4);
        public static readonly BodyNodeType Monster3 = new(5);
        public static readonly BodyNodeType Monster4 = new(6);
        public static readonly BodyNodeType Monster5 = new(7);
        public static readonly BodyNodeType Monster6 = new(8);
        public static readonly BodyNodeType Monster7 = new(9);
        public static readonly BodyNodeType Monster8 = new(10);
        public static readonly BodyNodeType Monster9 = new(11);

        public BodyNodeType(int internalValue) : base(internalValue)
        {
        }
    }
}
