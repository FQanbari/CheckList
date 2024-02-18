namespace CheckList.Application.Services;

public interface ITravelerCheckListReadService
{
    Task<bool> ExistByName(string name);
}