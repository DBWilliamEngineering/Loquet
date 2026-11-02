using System.Collections.ObjectModel;
using System.Reflection;
using Loquet.Core.Metadata.Abstractions.Mutable;
using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Configuration
{
    /// <summary>Owns explicit property registrations for a single CLR entity type.</summary>
    internal sealed class EntityTypeConfiguration : IMutableEntityType
    {
        private readonly Dictionary<string, PropertyConfiguration> _properties = new(StringComparer.Ordinal);
        private readonly List<IReadOnlyProperty> _propertyList = [];
        private readonly ReadOnlyCollection<IReadOnlyProperty> _propertyView;

        private string _datasetName;

        public EntityTypeConfiguration(ModelConfiguration model, Type clrType)
        {
            Model = model;
            ClrType = clrType;
            Name = clrType.FullName ?? clrType.Name;

            _datasetName = clrType.Name;
            _propertyView = _propertyList.AsReadOnly();
        }

        public string Name { get; }
        public Type ClrType { get; }
        public IReadOnlyModel Model { get; }

        public string DatasetName
        {
            get => _datasetName;
            set
            {
                ArgumentException.ThrowIfNullOrWhiteSpace(value);
                _datasetName = value;
            }
        }

        public IMutableProperty AddProperty(PropertyInfo propertyInfo)
        {
            ArgumentNullException.ThrowIfNull(propertyInfo);

            if (propertyInfo.DeclaringType is null || propertyInfo.DeclaringType.IsInterface ||
                !propertyInfo.DeclaringType.IsAssignableFrom(ClrType))
            {
                throw new ArgumentException($"Property '{propertyInfo.Name}' does not belong to entity '{Name}'.", nameof(propertyInfo));
            }

            if (propertyInfo.GetIndexParameters().Length != 0 ||
                propertyInfo.GetMethod is not { IsPublic: true, IsStatic: false } ||
                propertyInfo.SetMethod is not { IsPublic: true, IsStatic: false } setter ||
                setter.ReturnParameter.GetRequiredCustomModifiers()
                    .Contains(typeof(System.Runtime.CompilerServices.IsExternalInit)))
            {
                throw new ArgumentException($"Property '{Name}.{propertyInfo.Name}' must have a public instance getter and ordinary setter, and cannot be an indexer.", nameof(propertyInfo));
            }

            if (_properties.TryGetValue(propertyInfo.Name, out var existing))
            {

                if (existing.PropertyInfo.DeclaringType == propertyInfo.DeclaringType &&
                    existing.PropertyInfo.PropertyType == propertyInfo.PropertyType) return existing;

                throw new InvalidOperationException($"Entity '{Name}' already has a different CLR property named '{propertyInfo.Name}'.");
            }

            var property = new PropertyConfiguration(this, propertyInfo);

            _properties.Add(property.Name, property);
            _propertyList.Add(property);

            return property;
        }

        public IReadOnlyProperty? FindProperty(string name)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name);

            return _properties.GetValueOrDefault(name);
        }

        public IReadOnlyList<IReadOnlyProperty> GetProperties() => _propertyView;
    }
}
