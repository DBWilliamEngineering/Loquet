using Loquet.Core.Metadata.Abstractions;
using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata
{
    /// <summary>
    /// Runtime view of ServiceProperty metadata. Implementations must publish a stable, read-only graph.
    /// </summary>
    public interface IServiceProperty : IReadOnlyServiceProperty, IPropertyBase
    {
    }
}
