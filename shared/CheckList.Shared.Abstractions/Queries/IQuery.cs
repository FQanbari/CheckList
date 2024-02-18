using CheckList.Shared.Abstractions.Queries;

namespace CheckList.Shared.Abstractions.Queries;

public interface IQuery
{
}
public interface IQuery<TResult> : IQuery
{
}
