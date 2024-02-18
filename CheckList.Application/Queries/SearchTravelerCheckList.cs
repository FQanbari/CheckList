﻿using CheckList.Application.DTO;
using CheckList.Shared.Abstractions.Queries;

namespace CheckList.Application.Queries;

public class SearchTravelerCheckList : IQuery<IEnumerable<TravelCheckListDto>>
{
    public string SearchPhrase { get; set; }
}
