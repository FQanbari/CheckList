namespace CheckList.Shared.Abstractions.Domain;

public abstract class AggregateRoot<T>
{
    public T Id { get; protected set; }
    public int Version { get; protected set; }
    private bool _versionIncremented;

    public IEnumerable<IDomainEvent> Events => _events ;
    private readonly List<IDomainEvent> _events = new();
    protected void AddEvent(IDomainEvent @event)
    {
        if (!_events.Any() || _versionIncremented)
        {
            Version++;
            _versionIncremented = true;
        }

        _events.Add(@event);
    }
    public void ClearEvents() => _events.Clear();

    public void IncrementedVersion()
    {
        if (_versionIncremented) return;

        Version++;
        _versionIncremented = true;
    }
}
