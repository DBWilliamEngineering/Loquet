using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Abstractions.Mutable
{
    /// <summary>
    /// public model-building view of Annotatable metadata.
    /// </summary>
    public interface IMutableAnnotatable : IReadOnlyAnnotatable
    {
    }
}
