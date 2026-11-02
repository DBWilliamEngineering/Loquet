using System;
using System.Collections.Generic;
using System.Text;

namespace Loquet.Core.Metadata
{
    public interface IAnnotation
    {
        /// <summary>
        ///     Gets the key of this annotation.
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     Gets the value assigned to this annotation.
        /// </summary>
        object? Value { get; }
    }
}
