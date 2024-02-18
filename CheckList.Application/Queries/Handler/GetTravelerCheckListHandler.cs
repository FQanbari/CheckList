using CheckList.Application.DTO;
using CheckList.Domain.Repositories;
using CheckList.Shared.Abstractions.Queries;

namespace CheckList.Application.Queries.Handler;

public class GetTravelerCheckListHandler : IQueryHandler<GetTravelerCheckList, TravelCheckListDto>
{
    private readonly ITravelerCheckListRepository _repository;

    public GetTravelerCheckListHandler(ITravelerCheckListRepository repository)
    {
        _repository = repository;
    }
    public async Task<TravelCheckListDto> HandleAsync(GetTravelerCheckList query)
    {
        var travelerCheckList = await _repository.GetAsync(query.Id);
        //TODO: 
        return null; 
    }
}
