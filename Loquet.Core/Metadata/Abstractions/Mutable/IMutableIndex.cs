using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Abstractions.Mutable
{
    /// <summary>
    /// Public model-building view of Index metadata.
    /// </summary>
    public interface IMutableIndex : IReadOnlyIndex, IMutableAnnotatable
    {
    }
}
