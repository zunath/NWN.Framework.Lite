using System.Collections.Generic;

namespace NWN.Framework.Lite.Enum
{
    public abstract class NWEnumBase<T>
    {
        public T InternalValue { get; protected set; }

        protected NWEnumBase(T internalValue)
        {
            InternalValue = internalValue;
        }

        protected bool Equals(NWEnumBase<T> other)
        {
            return EqualityComparer<T>.Default.Equals(InternalValue, other.InternalValue);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((NWEnumBase<T>) obj);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<T>.Default.GetHashCode(InternalValue);
        }


        public static bool operator ==(NWEnumBase<T> lhs, NWEnumBase<T> rhs)
        {
            // Check for null.
            if (ReferenceEquals(lhs, null))
            {
                return ReferenceEquals(rhs, null);
            }

            return !(rhs == null) && lhs.InternalValue.Equals(rhs.InternalValue);

            // Equals handles the case of null on right side.
        }

        public static bool operator !=(NWEnumBase<T> lhs, NWEnumBase<T> rhs)
        {
            if (ReferenceEquals(lhs, null))
            {
                return ReferenceEquals(rhs, null);
            }

            // Left hand side is not null but right hand side is, return false.
            if (rhs == null)
                return false;

            return !lhs.InternalValue.Equals(rhs.InternalValue);
        }
    }
}
