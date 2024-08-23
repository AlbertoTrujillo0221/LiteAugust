using Application.UseCases.Common.Results;
using MediatR;

namespace Application.UseCases.Transactions.Queries.GetTransactions
{
    public class GetTransactionsQuery : IRequest<Result<GetTransactionsQueryDto>>
    {
        
    }
}
