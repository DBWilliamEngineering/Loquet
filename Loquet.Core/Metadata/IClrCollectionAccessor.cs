using System;
using System.Collections.Generic;
using System.Text;

namespace Loquet.Core.Metadata
{
    public interface IClrCollectionAccessor
    {
        bool Add(object entity, object value, bool forMaterialization);

        bool Contains(object entity, object value);

        bool Remove(object entity, object value);

        bool AddStandalone(object collection, object value);

        bool ContainsStandalone(object collection, object value);

        bool RemoveStandalone(object? collection, object value);

        object Create();

        object GetOrCreate(object entity, bool forMaterialization);

        Type CollectionType { get; }
    }
}
