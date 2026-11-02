using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Abstractions.Mutable
{
    /// <summary>
    /// public model-building view of EntityType metadata.
    /// </summary>
    public interface IMutableEntityType : IReadOnlyEntityType, IMutableTypeBase
    {
        new string DatasetName { get; set; }
    }
}
