namespace CheckList.Shared.Abstractions.Domain;

public abstract class AggregateRoot<T>
{
    public T Id { get; protected set; }
    public int Version { get; protected set; }
    private bool _versionIncremented;

    public void IncrementedVersion()
    {
        if (_versionIncremented) return;

        Version++;
        _versionIncremented = true;
    }
}
