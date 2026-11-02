using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Abstractions.Mutable
{
    /// <summary>
    /// public model-building view of PropertyBase metadata.
    /// </summary>
    public interface IMutablePropertyBase :IReadOnlyPropertyBase, IMutableAnnotatable
    {
    }
}
