namespace Loquet.Core.Metadata.Abstractions.ReadOnly
{
    /// <summary>
    /// Shared, non-mutating description of TypeBase metadata.
    /// </summary>
    public interface IReadOnlyTypeBase : IReadOnlyAnnotatable
    {
        string Name { get; }
        Type ClrType { get; }
        IReadOnlyModel Model { get; }
        IReadOnlyProperty? FindProperty(string name);
        IReadOnlyList<IReadOnlyProperty> GetProperties();
    }
}
