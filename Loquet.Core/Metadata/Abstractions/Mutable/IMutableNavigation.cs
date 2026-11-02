using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Abstractions.Mutable
{
    /// <summary>
    /// public model-building view of Navigation metadata.
    /// </summary>
    public interface IMutableNavigation :IReadOnlyNavigation, IMutableNavigationBase
    {
    }
}
