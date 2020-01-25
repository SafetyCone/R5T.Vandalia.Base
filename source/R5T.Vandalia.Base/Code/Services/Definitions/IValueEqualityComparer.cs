using System;


namespace R5T.Vandalia
{
    /// <summary>
    /// Allows comparing the equality of objects.
    /// Basically, this is <see cref="System.Collections.Generic.IEqualityComparer{T}"/> without the requirement to implement GetHashCode().
    /// </summary>
    public interface IValueEqualityComparer<T>
    {
        bool Equals(T x, T y);
    }
}
