using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Abstractions.Mutable
{
    /// <summary>
    /// public model-building view of NavigationBase metadata.
    /// </summary>
    public interface IMutableNavigationBase : IReadOnlyNavigationBase, IMutablePropertyBase
    {
    }
}
