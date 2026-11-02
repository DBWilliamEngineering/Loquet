using Loquet.Core.Metadata.Builder;

namespace Loquet.Core
{
    /// <summary>Defines an entity's mapping independently of a context.</summary>
    public interface IEntityTypeConfiguration<TEntity> where TEntity : class
    {
        void Configure(EntityTypeBuilder<TEntity> builder);
    }
}
