using System;
using System.Collections.Generic;
using System.Text;
using Loquet.Core.Metadata;
using Loquet.Core.Metadata.Abstractions;

namespace Loquet.Core.Update
{
    public interface IUpdateParquetEntry
    {
        ParquetContext Context { get; }

        void SetOriginalValue(IProperty property, object? value);

        void SetPropertyModified(IProperty property);

        IEntityType EntityType { get; }

        ParquetEntityState EntityState { get; set; }

        IUpdateParquetEntry? SharedIdentityEntry { get; }

        bool IsModified(IProperty property);

        bool IsLoaded(IProperty property);

        bool IsModified(IComplexProperty property);

        bool HasTemporaryValue(IProperty property);

        bool HasExplicitValue(IProperty property);
        bool HasStoreGeneratedValue(IProperty property);
        bool IsStoreGenerated(IProperty property);
        object? GetCurrentValue(IPropertyBase propertyBase);
        object? GetOriginalValue(IPropertyBase propertyBase);

        bool CanHaveOriginalValue(IPropertyBase propertyBase);
        TProperty GetCurrentValue<TProperty>(IPropertyBase propertyBase);
        TProperty GetOriginalValue<TProperty>(IProperty property);
        void SetStoreGeneratedValue(IProperty property, object? value, bool setModified = true);
        EntityEntry ToEntityEntry();
        object? GetRelationshipSnapshotValue(IPropertyBase propertyBase);

        object? GetPreStoreGeneratedCurrentValue(IPropertyBase propertyBase);
        bool IsConceptualNull(IProperty property);
    }
}
