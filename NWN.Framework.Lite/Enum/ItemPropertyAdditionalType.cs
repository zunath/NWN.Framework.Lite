namespace NWN.Framework.Lite.Enum
{
    /// <summary>
    ///   For use with ItemPropertyAdditional() . References iprp_addcost.2da.
    /// </summary>
    public class ItemPropertyAdditionalType: NWEnumBase<int>
    {
        public static readonly ItemPropertyAdditionalType Unknown = new(0);
        public static readonly ItemPropertyAdditionalType Cursed = new(1);

        public ItemPropertyAdditionalType(int internalValue) : base(internalValue)
        {
        }
    }
}