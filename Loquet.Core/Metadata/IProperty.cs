using Loquet.Core.Metadata.Abstractions;
using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata
{
    /// <summary>
    /// Runtime view of Property metadata. Implementations must publish a stable, read-only graph.
    /// </summary>
    public interface IProperty : IReadOnlyProperty, IPropertyBase
    {
    }
}
