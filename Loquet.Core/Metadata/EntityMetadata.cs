using System;
using System.Collections.Generic;
using System.Text;

namespace Loquet.Core.Metadata
{
    public class EntityMetadata
    {
        public required PropertyMetadata PrimaryKey { get; set; }
        public required string Name { get; set; }
        public required Type Type { get; set; }
        public required IReadOnlyList<PropertyMetadata> Properties { get; set; }
    }
}
