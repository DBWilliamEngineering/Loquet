using System.Reflection;
using Loquet.Core.Metadata.Abstractions.Mutable;
using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Configuration
{
    /// <summary>Keeps CLR identity fixed while allowing column and nullability configuration.</summary>
    internal sealed class PropertyConfiguration : IMutableProperty
    {
        private string _columnName;
        private bool _isNullable;

        public PropertyConfiguration(EntityTypeConfiguration declaringType, PropertyInfo propertyInfo)
        {
            DeclaringType = declaringType;
            PropertyInfo = propertyInfo;

            _columnName = propertyInfo.Name;

            var nullability = new NullabilityInfoContext().Create(propertyInfo);

            _isNullable = Nullable.GetUnderlyingType(ClrType) is not null ||
                (!ClrType.IsValueType && (nullability.ReadState != NullabilityState.NotNull ||
                                        nullability.WriteState != NullabilityState.NotNull));
        }

        public string Name => PropertyInfo.Name;
        public Type ClrType => PropertyInfo.PropertyType;
        public IReadOnlyTypeBase DeclaringType { get; }
        public PropertyInfo PropertyInfo { get; }

        public string ColumnName
        {
            get => _columnName;
            set
            {
                ArgumentException.ThrowIfNullOrWhiteSpace(value);
                _columnName = value;
            }
        }

        public bool IsNullable
        {
            get => _isNullable;
            set
            {
                if (value && ClrType.IsValueType && Nullable.GetUnderlyingType(ClrType) is null)
                {
                    throw new InvalidOperationException($"Property '{DeclaringType.Name}.{Name}' has CLR type '{ClrType}' and cannot accept null.");
                }

                _isNullable = value;
            }
        }
    }
}
