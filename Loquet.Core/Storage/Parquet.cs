using System;
using System.Collections.Generic;
using System.Text;
using Loquet.Core.Update;

namespace Loquet.Core.Storage
{
    public class Parquet : IParquet
    {
        public int SaveChanges(IList<IUpdateParquetEntry> entries)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync(IList<IUpdateParquetEntry> entries, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
