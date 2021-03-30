namespace NWN.Framework.Lite.Enum
{
    public abstract class NWEnumBase<T>
    {
        public T InternalValue { get; protected set; }

        protected NWEnumBase(T internalValue)
        {
            InternalValue = internalValue;
        }
    }
}
