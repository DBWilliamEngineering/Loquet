using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Abstractions.Mutable
{
    /// <summary>
    /// public model-building view of ServiceProperty metadata.
    /// </summary>
    public interface IMutableServiceProperty : IReadOnlyServiceProperty, IMutablePropertyBase
    {
    }
}
