using Loquet.Core.Metadata.Abstractions;
using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata
{
    /// <summary>
    /// Runtime view of ComplexProperty metadata. Implementations must publish a stable, read-only graph.
    /// </summary>
    public interface IComplexProperty : IReadOnlyComplexProperty, IPropertyBase
    {
    }
}
