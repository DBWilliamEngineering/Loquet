using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Abstractions.Mutable
{
    /// <summary>
    /// Public model-building view of ForeignKey metadata.
    /// </summary>
    public interface IMutableForeignKey :IReadOnlyForeignKey, IMutableAnnotatable
    {
    }
}
