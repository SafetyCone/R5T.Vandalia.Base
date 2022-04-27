using System;

using R5T.T0064;


namespace R5T.Vandalia
{
    /// <summary>
    /// Allows comparing the equality of objects.
    /// Basically, this is <see cref="System.Collections.Generic.IEqualityComparer{T}"/> without the requirement to implement GetHashCode().
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IValueEqualityComparer<T> : IServiceDefinition
    {
        bool Equals(T x, T y);
    }
}
