using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Abstractions
{
    /// <summary>
    /// Runtime view of TypeBase metadata. Implementations must publish a stable, read-only graph.
    /// </summary>
    public interface ITypeBase : IReadOnlyTypeBase, IAnnotatable
    {
    }
}
