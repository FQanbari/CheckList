namespace CheckList.Application.Services;

public interface ITravelerCheckListReadService
{
    Task<bool> ExistsByNameAsync(string name);
}