using CheckList.Domain.Entities;
using CheckList.Domain.ValueObjects;
using CheckList.Shared.Abstractions.Domain;

namespace CheckList.Domain.Events;

public record TravelerItemAdded(TravelerCheckList TravelerCheckList, TravelerItem TravelerItem) : IDomainEvent;
