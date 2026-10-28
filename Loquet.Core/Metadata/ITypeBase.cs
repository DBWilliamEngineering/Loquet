using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Loquet.Core.Metadata.Abstractions;

namespace Loquet.Core.Metadata
{
    public interface ITypeBase
    {
        new IModel Model { get; }

        new IEntityType ContainingEntityType
            => (IEntityType)this;

        new ITypeBase? BaseType { get; }

        new IEnumerable<ITypeBase> GetDerivedTypes()
            => ((IReadOnlyTypeBase)this).GetDerivedTypes().Cast<ITypeBase>();

        new IEnumerable<ITypeBase> GetDerivedTypesInclusive()
            => ((IReadOnlyTypeBase)this).GetDerivedTypesInclusive().Cast<ITypeBase>();

        new IEnumerable<ITypeBase> GetDirectlyDerivedTypes();

        new IProperty? FindDiscriminatorProperty()
            => (IProperty?)((IReadOnlyTypeBase)this).FindDiscriminatorProperty();

        new IProperty? FindProperty(MemberInfo memberInfo)
            => (IProperty?)((IReadOnlyTypeBase)this).FindProperty(memberInfo);
        new IProperty? FindProperty(string name);

        new IReadOnlyList<IProperty>? FindProperties(
            IReadOnlyList<string> propertyNames)
            => (IReadOnlyList<IProperty>?)((IReadOnlyTypeBase)this).FindProperties(propertyNames);
        new IProperty GetProperty(string name)
            => (IProperty)((IReadOnlyTypeBase)this).GetProperty(name);

        new IProperty? FindDeclaredProperty(string name)
            => (IProperty?)((IReadOnlyTypeBase)this).FindDeclaredProperty(name);
        new IEnumerable<IProperty> GetDeclaredProperties();

        new IEnumerable<IProperty> GetDerivedProperties()
            => ((IReadOnlyTypeBase)this).GetDerivedProperties().Cast<IProperty>();
        new IEnumerable<IProperty> GetProperties();
        IEnumerable<IProperty> GetFlattenedValueGeneratingProperties();
        new IComplexProperty? FindComplexProperty(string name);
        new IComplexProperty? FindComplexProperty(MemberInfo memberInfo)
            => (IComplexProperty?)((IReadOnlyTypeBase)this).FindComplexProperty(memberInfo);
        new IComplexProperty? FindDeclaredComplexProperty(string name)
            => (IComplexProperty?)((IReadOnlyTypeBase)this).FindDeclaredComplexProperty(name);
        new IEnumerable<IComplexProperty> GetComplexProperties();
        new IEnumerable<IComplexProperty> GetDeclaredComplexProperties();
        new IEnumerable<IComplexProperty> GetDerivedComplexProperties()
            => ((IReadOnlyTypeBase)this).GetDerivedComplexProperties().Cast<IComplexProperty>();
        new IEnumerable<IPropertyBase> GetMembers();
        new IEnumerable<IPropertyBase> GetDeclaredMembers();
        new IPropertyBase? FindMember(string name);
        new IEnumerable<IPropertyBase> FindMembersInHierarchy(string name);

        IEnumerable<IPropertyBase> GetSnapshottableMembers();
        IEnumerable<IProperty> GetPropertiesInHierarchy()
            => throw new NotSupportedException();
        IEnumerable<IProperty> GetFlattenedProperties();

        IEnumerable<IComplexProperty> GetFlattenedComplexProperties();
        IEnumerable<IProperty> GetFlattenedDeclaredProperties();
        IEnumerable<IProperty> GetFlattenedPropertiesInHierarchy()
            => throw new NotSupportedException();
    }
}
