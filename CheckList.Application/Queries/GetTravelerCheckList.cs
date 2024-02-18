using CheckList.Application.DTO;
using CheckList.Shared.Abstractions.Queries;

namespace CheckList.Application.Queries;

public class GetTravelerCheckList : IQuery<TravelCheckListDto>
{
    public Guid Id { get; set; }
}
