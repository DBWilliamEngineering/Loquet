using System;
using System.Collections.Generic;
using System.Text;

namespace Loquet.Core.Metadata
{
    public interface IMetadataReference<out T> : IDisposable
    {
        /// <summary>
        ///     The referenced object.
        /// </summary>
        T? Object { get; }
    }
}
