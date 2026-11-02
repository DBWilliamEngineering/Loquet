using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Abstractions
{
    /// <summary>
    /// Runtime view of NavigationBase metadata. Implementations must publish a stable, read-only graph.
    /// </summary>
    public interface INavigationBase : IReadOnlyNavigationBase, IPropertyBase
    {
    }
}
