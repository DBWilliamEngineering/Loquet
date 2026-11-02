using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata
{
    /// <summary>
    /// Runtime view of Annotatable metadata. Implementations must publish a stable, read-only graph.
    /// </summary>
    public interface IAnnotatable : IReadOnlyAnnotatable
    {
    }
}
