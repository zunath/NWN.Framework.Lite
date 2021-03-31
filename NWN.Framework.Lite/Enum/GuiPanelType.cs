namespace NWN.Framework.Lite.Enum
{
    public class GuiPanelType: NWEnumBase<int>
    {
        public static readonly GuiPanelType PlayerDeath = new(0);

        public GuiPanelType(int internalValue) : base(internalValue)
        {
        }
    }
}