using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata
{
    /// <summary>
    /// Runtime view of ElementType metadata. Implementations must publish a stable, read-only graph.
    /// </summary>
    public interface IElementType : IReadOnlyElementType, IAnnotatable
    {
    }
}
