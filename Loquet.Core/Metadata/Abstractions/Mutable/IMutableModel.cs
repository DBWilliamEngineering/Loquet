using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Abstractions.Mutable
{
    /// <summary>
    /// public model-building view of Model metadata.
    /// </summary>
    public interface IMutableModel : IReadOnlyModel, IMutableAnnotatable
    {
        IMutableEntityType AddEntityType(Type clrType);
    }
}
