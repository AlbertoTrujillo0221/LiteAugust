using Application.UseCases.Common.Handlers;
using Application.UseCases.Common.Results;
using MediatR;

namespace Application.UseCases.Transactions.Queries.GetTransactions
{
    public class GetTransactionsQuery : IRequest<Result<GetTransactionsQueryDto>>
    {
        public class GetTransactionsQueryHandler() : UseCaseHandler, IRequestHandler<GetTransactionsQuery, Result<GetTransactionsQueryDto>>
        {
            public async Task<Result<GetTransactionsQueryDto>> Handle(GetTransactionsQuery request, CancellationToken cancellationToken)
            {
                await Task.CompletedTask;

                var transactions = new List<GetTransactionsQueryValueDto>()
                {
                    new GetTransactionsQueryValueDto()
                    {
                        Id = 1,
                        Value = 1500
                    },
                    new GetTransactionsQueryValueDto()
                    {
                        Id = 2,
                        Value = 3500
                    },
                    new GetTransactionsQueryValueDto()
                    {
                        Id = 3,
                        Value = 4500
                    }
                };


                var response = new GetTransactionsQueryDto()
                {
                    Transactions = transactions
                };

                return Succeded(response);
            }
        }
    }
}
