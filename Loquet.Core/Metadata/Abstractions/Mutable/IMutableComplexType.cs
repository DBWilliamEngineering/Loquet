using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Abstractions.Mutable
{
    /// <summary>
    /// public model-building view of ComplexType metadata.
    /// </summary>
    public interface IMutableComplexType : IReadOnlyComplexType, IMutableTypeBase
    {
    }
}
