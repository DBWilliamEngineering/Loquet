using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Loquet.Core.Metadata
{
    public class PropertyMetadata
    {
        public required string Name { get; set; }
        public required string Column { get; set; }
        public required Type Type { get; set; }
        public required bool Nullable { get; set; }
        public required PropertyInfo PropertyInfo { get; set; }
    }
}
