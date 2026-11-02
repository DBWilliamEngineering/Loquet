using System;

using Loquet.Core.Metadata.Abstractions.Mutable;
using Loquet.Core.Metadata.Configuration;

namespace Loquet.Core.Metadata.Builder
{
    public class LoquetModelBuilder
    {
        /// <summary>The live configuration graph; this is not finalized runtime metadata.</summary>
        public IMutableModel Model { get; } = new ModelConfiguration();

        public EntityTypeBuilder<TEntity> Entity<TEntity>() where TEntity : class
            => new(Model.AddEntityType(typeof(TEntity)));

        /// <summary>
        /// Applies an external configuration to this model. Calls execute in order;
        /// repeated explicit assignments use the last value. No assembly scanning is performed.
        /// </summary>
        public LoquetModelBuilder ApplyConfiguration<TEntity>(IEntityTypeConfiguration<TEntity> configuration)
            where TEntity : class
        {
            ArgumentNullException.ThrowIfNull(configuration);

            configuration.Configure(Entity<TEntity>());

            return this;
        }
    }
}
