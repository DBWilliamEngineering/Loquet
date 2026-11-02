using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Abstractions
{
    /// <summary>
    /// Runtime view of PropertyBase metadata. Implementations must publish a stable, read-only graph.
    /// </summary>
    public interface IPropertyBase :IReadOnlyPropertyBase, IAnnotatable
    {
    }
}
