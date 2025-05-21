

namespace Core.Domain.Common;

public abstract class ValueObject<T> where T : notnull
{
    public T Value { get; set; }

    protected ValueObject()
    {
        
    }
    public ValueObject(T value)
    {
        Value = value;
    }
}
