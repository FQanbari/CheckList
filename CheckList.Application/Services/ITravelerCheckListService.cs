namespace CheckList.Application.Services;

public interface ITravelerCheckListService
{
    Task<bool> ExistByName(string name);
}