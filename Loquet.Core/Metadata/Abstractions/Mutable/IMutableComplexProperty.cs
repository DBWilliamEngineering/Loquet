using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Abstractions.Mutable
{
    /// <summary>
    /// public model-building view of ComplexProperty metadata.
    /// </summary>
    public interface IMutableComplexProperty : IReadOnlyComplexProperty, IMutablePropertyBase
    {
    }
}
