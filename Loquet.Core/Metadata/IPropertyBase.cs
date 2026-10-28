using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using Loquet.Core.Metadata.Abstractions;
using Loquet.Core.Update;

namespace Loquet.Core.Metadata
{
    public interface IPropertyBase : IReadOnlyPropertyBase
    {
        new ITypeBase DeclaringType
        {
            [DebuggerStepThrough]
            get => (ITypeBase)((IReadOnlyPropertyBase)this).DeclaringType;
        }

        IPropertyGetter GetGetter();

        MemberInfo GetMemberInfo(bool forMaterialization, bool forSet)
            => this.TryGetMemberInfo(forMaterialization, forSet, out var memberInfo, out var errorMessage)
                ? memberInfo!
                : throw new InvalidOperationException(errorMessage);

        int GetIndex()
            => this.GetPropertyIndexes().Index;

        IComparer<IUpdateParquetEntry> GetCurrentValueComparer();
    }
}
