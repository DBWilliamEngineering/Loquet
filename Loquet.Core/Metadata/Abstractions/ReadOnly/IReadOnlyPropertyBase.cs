namespace Loquet.Core.Metadata.Abstractions.ReadOnly
{
    /// <summary>
    /// Shared, non-mutating description of PropertyBase metadata.
    /// </summary>
    public interface IReadOnlyPropertyBase : IReadOnlyAnnotatable
    {
        string Name { get; }
        Type ClrType { get; }
        IReadOnlyTypeBase DeclaringType { get; }
        System.Reflection.PropertyInfo PropertyInfo { get; }
    }
}
