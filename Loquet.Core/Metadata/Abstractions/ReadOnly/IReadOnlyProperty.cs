namespace Loquet.Core.Metadata.Abstractions.ReadOnly
{
    /// <summary>
    /// Shared, non-mutating description of Property metadata.
    /// </summary>
    public interface IReadOnlyProperty : IReadOnlyPropertyBase
    {
        string ColumnName { get; }
        bool IsNullable { get; }
    }
}
