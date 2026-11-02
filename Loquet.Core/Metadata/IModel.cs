using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata
{
    /// <summary>
    /// Runtime view of Model metadata. Implementations must publish a stable, read-only graph.
    /// </summary>
    public interface IModel : IReadOnlyModel, IAnnotatable
    {
    }
}
