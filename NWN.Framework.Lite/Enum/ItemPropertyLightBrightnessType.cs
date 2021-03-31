namespace NWN.Framework.Lite.Enum
{
    public class ItemPropertyLightBrightnessType: NWEnumBase<int>
    {
        public static readonly ItemPropertyLightBrightnessType LightBrightnessDim = new(1);
        public static readonly ItemPropertyLightBrightnessType LightBrightnessLow = new(2);
        public static readonly ItemPropertyLightBrightnessType LightBrightnessNormal = new(3);
        public static readonly ItemPropertyLightBrightnessType LightBrightnessBright = new(4);

        public ItemPropertyLightBrightnessType(int internalValue) : base(internalValue)
        {
        }
    }
}