using System.Reflection;
using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Abstractions.Mutable
{
    /// <summary>
    /// public model-building view of TypeBase metadata.
    /// </summary>
    public interface IMutableTypeBase : IReadOnlyTypeBase, IMutableAnnotatable
    {
        IMutableProperty AddProperty(PropertyInfo propertyInfo);
    }
}
