using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Abstractions.Mutable
{
    /// <summary>
    /// public model-building view of Property metadata.
    /// </summary>
    public interface IMutableProperty : IReadOnlyProperty, IMutablePropertyBase
    {
        new string ColumnName { get; set; }
        new bool IsNullable { get; set; }
    }
}
