using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Text;
using Loquet.Core.Update;

namespace Loquet.Core.Storage
{
    public interface IParquet
    {
        int SaveChanges(IList<IUpdateParquetEntry> entries);

        Task<int> SaveChangesAsync(
            IList<IUpdateParquetEntry> entries,
            CancellationToken cancellationToken = default);
    }
}
