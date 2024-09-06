using Application.Common.Interfaces;
using Application.UseCases.Common.Handlers;
using Application.UseCases.Common.Results;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Transactions.Queries.GetTransactions
{
    public class GetTransactionsQuery() : IRequest<Result<GetTransactionsQueryDto>>
    {
        public class GetTransactionsQueryHandler(IRepository<Transaction> repository) : UseCaseHandler, IRequestHandler<GetTransactionsQuery, Result<GetTransactionsQueryDto>>
        {
            public async Task<Result<GetTransactionsQueryDto>> Handle(GetTransactionsQuery request, CancellationToken cancellationToken)
            {
                var result = await repository.GetAllAsync();

                var transactions = result.Select(x => new GetTransactionsQueryValueDto
                {
                    Id = x.Id,
                    Title = x.Title,
                }).ToList();

                var response = new GetTransactionsQueryDto()
                {
                    Transactions = transactions
                };

                return Succeded(response);
            }
        }
    }
}
