using System.Collections.ObjectModel;
using Loquet.Core.Metadata.Abstractions.Mutable;
using Loquet.Core.Metadata.Abstractions.ReadOnly;

namespace Loquet.Core.Metadata.Configuration
{
    /// <summary>Owns the entities registered during model construction.</summary>
    internal sealed class ModelConfiguration : IMutableModel
    {
        private readonly Dictionary<Type, EntityTypeConfiguration> _entities = new();
        private readonly List<IReadOnlyEntityType> _entityList = [];
        private readonly ReadOnlyCollection<IReadOnlyEntityType> _entityView;

        public ModelConfiguration()
        {
            _entityView = _entityList.AsReadOnly();
        }

        public IMutableEntityType AddEntityType(Type clrType)
        {
            ArgumentNullException.ThrowIfNull(clrType);
            if (!clrType.IsClass || clrType.IsAbstract || clrType.ContainsGenericParameters ||
                clrType == typeof(string))
            {
                throw new ArgumentException("An entity must be a concrete, closed CLR class other than string.", nameof(clrType));
            }

            if (_entities.TryGetValue(clrType, out var existing))
            {
                return existing;

            }

            var entity = new EntityTypeConfiguration(this, clrType);

            _entities.Add(clrType, entity);
            _entityList.Add(entity);

            return entity;
        }

        public IReadOnlyEntityType? FindEntityType(Type clrType)
        {
            ArgumentNullException.ThrowIfNull(clrType);

            return _entities.GetValueOrDefault(clrType);
        }

        public IReadOnlyList<IReadOnlyEntityType> GetEntityTypes() => _entityView;
    }
}
