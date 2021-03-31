namespace NWN.Framework.Lite.Enum
{
    public class SkyboxType : NWEnumBase<int>
    {
        // these constants must match those in the skyboxes.2da
        public static readonly SkyboxType None = new(0);
        public static readonly SkyboxType GrassClear = new(1);
        public static readonly SkyboxType GrassStorm = new(2);
        public static readonly SkyboxType DesertClear = new(3);
        public static readonly SkyboxType WinterClear = new(4);
        public static readonly SkyboxType Icy  = new(5);

        public SkyboxType(int internalValue) : base(internalValue) { }
    }
}