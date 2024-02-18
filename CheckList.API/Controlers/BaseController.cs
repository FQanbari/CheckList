using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
namespace CheckList.API.Controlers;

//dotnet ef migrations add Init_Read --context ReadDbContext --startup-project../CheckList.API/  -o Ef/Migrations

[ApiController]
[Route("api/[controller]")]
public abstract class BaseController : ControllerBase
{
    protected ActionResult<TResult> OkOrNotFound<TResult>(TResult result)
        => result is null ? NotFound() : Ok(result);
}
