using CheckList.Application.DTO;
using CheckList.Shared.Abstractions.Queries;

namespace CheckList.Application.Queries;

public class GetTravelerCheckList : IQuery<TravelerCheckListDto>
{
    public Guid Id { get; set; }
}
