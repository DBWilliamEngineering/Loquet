using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Abstractions.Mutable
{
    /// <summary>
    /// public model-building view of Key metadata.
    /// </summary>
    public interface IMutableKey : IReadOnlyKey, IMutableAnnotatable
    {
    }
}
