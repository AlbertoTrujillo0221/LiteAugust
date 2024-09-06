using Application.Common.Interfaces;
using Application.UseCases.Common.Handlers;
using Application.UseCases.Common.Results;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Transactions.Commands.CreateTransaction
{
    public class CreateTransactionCommand : CreateTransactionCommandModel, IRequest<Result<CreateTransactionCommandDto>>
    {
        public class CreateTransactionCommandHandler(IRepository<Transaction> repository) : UseCaseHandler, IRequestHandler<CreateTransactionCommand, Result<CreateTransactionCommandDto>>
        {
            public async Task<Result<CreateTransactionCommandDto>> Handle(CreateTransactionCommand request, CancellationToken cancellationToken)
            {
                var transaction = new Transaction()
                {
                    Id = request.Id,
                    Title = request.Title,
                };

                await repository.AddAsync(transaction);

                var response = new CreateTransactionCommandDto()
                {
                    Success = true
                };

                return Succeded(response);
            }
        }
    }
}