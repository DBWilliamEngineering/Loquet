using System;
using Loquet.Core.Metadata.Abstractions.Mutable;

namespace Loquet.Core.Metadata.Builder
{
    public class EntityTypeBuilder
    {
        internal EntityTypeBuilder(IMutableEntityType metadata)
        {
            Metadata = metadata;
        }

        /// <summary>The live entity configuration shared by builders for this entity.</summary>
        public IMutableEntityType Metadata { get; }
    }

}
