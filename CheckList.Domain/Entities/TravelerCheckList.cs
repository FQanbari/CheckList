using CheckList.Domain.ValueObjects;

namespace CheckList.Domain.Entities;

public class TravelerCheckList
{
    public TravelerCheckListId Id { get; private set; }
    public TravelerCheckListName _name;
    public Destination _destination;

    private readonly LinkedList<TravelerItem> _items = new();

    
    internal TravelerCheckList(TravelerCheckListId id, TravelerCheckListName name, Destination destination)
    {
        Id = id;
        _name = name;
        _destination = destination;
    }
    private TravelerCheckList(TravelerCheckListId id, TravelerCheckListName name, Destination destination, LinkedList<TravelerItem> items)
        :this(id, name, destination) 
    {
        _items = items;
    }
    public TravelerCheckList() {}

}
