using CheckList.Domain.ValueObjects;

namespace CheckList.Domain.Policies;

public record PolicyData(TravelDays Days, Consts.Gender Gender, Temperature Temperature, Destination Destination)
{
}
