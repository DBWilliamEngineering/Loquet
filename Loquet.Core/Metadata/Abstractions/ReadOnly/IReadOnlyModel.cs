namespace Loquet.Core.Metadata.Abstractions.ReadOnly
{
    /// <summary>
    /// Shared, non-mutating description of Model metadata.
    /// </summary>
    public interface IReadOnlyModel : IReadOnlyAnnotatable
    {
        IReadOnlyEntityType? FindEntityType(Type clrType);
        IReadOnlyList<IReadOnlyEntityType> GetEntityTypes();
    }
}
