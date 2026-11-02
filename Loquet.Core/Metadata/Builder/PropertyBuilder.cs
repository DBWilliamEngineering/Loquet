using Loquet.Core.Metadata.Abstractions.Mutable;

namespace Loquet.Core.Metadata.Builder
{
    public class PropertyBuilder<TProperty>
    {
        internal PropertyBuilder(IMutableProperty metadata)
        {
            Metadata = metadata;
        }

        public IMutableProperty Metadata { get; }

        public PropertyBuilder<TProperty> HasColumnName(string name)
        {
            Metadata.ColumnName = name;

            return this;
        }

        public PropertyBuilder<TProperty> IsRequired(bool required = true)
        {
            Metadata.IsNullable = !required;

            return this;
        }
    }
}
