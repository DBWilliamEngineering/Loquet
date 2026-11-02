namespace Loquet.Core.Metadata.Abstractions.ReadOnly
{
    /// <summary>
    /// Shared, non-mutating description of EntityType metadata.
    /// </summary>
    public interface IReadOnlyEntityType : IReadOnlyTypeBase
    {
        /// <summary>Logical dataset name; filesystem resolution belongs to the provider.</summary>
        string DatasetName { get; }
    }
}
