using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Abstractions.Convention
{
    /// <summary>
    /// Reserved convention view of TypeBase metadata. Precedence-aware mutation is deferred.
    /// </summary>
    public interface IConventionTypeBase :IReadOnlyTypeBase, IConventionAnnotatable
    {
    }
}
