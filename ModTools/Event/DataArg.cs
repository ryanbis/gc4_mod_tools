namespace ModTools.Event;

public class DataArg<T> : EventArgs
{
    public T? Value { get; }

    public DataArg(T value)
    {
        Value = value;
    }
}