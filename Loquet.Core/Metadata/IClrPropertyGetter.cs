namespace Loquet.Core.Metadata
{
    /// <summary>
    /// Reads a mapped CLR member without sentinel or tracking semantics.
    /// </summary>
    public interface IClrPropertyGetter
    {
        object? GetClrValue(object instance);
    }
}
