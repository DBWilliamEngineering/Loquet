namespace Loquet.Core.Metadata
{
    /// <summary>
    /// Writes a mapped CLR member. Accessor implementations are deferred.
    /// </summary>
    public interface IClrPropertySetter
    {
        void SetClrValue(object instance, object? value);
    }
}
