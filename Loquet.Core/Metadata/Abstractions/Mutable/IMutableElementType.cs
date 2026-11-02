using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Abstractions.Mutable
{
    /// <summary>
    /// public model-building view of ElementType metadata.
    /// </summary>
    public interface IMutableElementType : IReadOnlyElementType, IMutableAnnotatable
    {
    }
}
