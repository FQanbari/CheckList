using CheckList.Application.DTO;
using CheckList.Infrastructure.Ef.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList.Infrastructure.Ef.Queries;

internal static class Extenstions
{
    public static TravelerCheckListDto AsDto(this TravelerCheckListReadModel readModel)
        => new()
        {
            Id = readModel.Id,
            Name = readModel.Name,
            Destination = new DestinationDto
            {
                City = readModel.Destination.City,
                Country = readModel.Destination.Country,
            },
            Items = readModel.Items?.Select(x => new TravelItemDto
            {
                Name = x.Name,
                Quantity = x.Quantity,
                IsTaken = x.IsTaken
            }),
        };
}
