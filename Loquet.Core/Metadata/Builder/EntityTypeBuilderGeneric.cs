using System.Linq.Expressions;
using System.Reflection;
using Loquet.Core.Metadata.Abstractions.Mutable;

namespace Loquet.Core.Metadata.Builder
{
    public class EntityTypeBuilder<TEntity> : EntityTypeBuilder where TEntity : class
    {
        internal EntityTypeBuilder(IMutableEntityType metadata) : base(metadata)
        {
        }

        public EntityTypeBuilder<TEntity> ToDataset(string name)
        {
            Metadata.DatasetName = name;

            return this;
        }

        /// <summary>Explicitly registers a direct CLR property; automatic discovery is deferred.</summary>
        public PropertyBuilder<TProperty> Property<TProperty>(Expression<Func<TEntity, TProperty>> expression)
        {
            ArgumentNullException.ThrowIfNull(expression);

            if (expression.Body is not MemberExpression { Member: PropertyInfo property } member ||
                member.Expression != expression.Parameters[0] || property.PropertyType != typeof(TProperty))
            {
                throw new ArgumentException("Select a direct entity property, such as entity => entity.Name. Nested members, fields and conversions are not supported.", nameof(expression));
            }

            return new PropertyBuilder<TProperty>(Metadata.AddProperty(property));
        }
    }
}
