using Application.UseCases.Transactions.Commands.CreateTransaction;
using Application.UseCases.Transactions.Queries.GetTransactions;
using Microsoft.AspNetCore.Mvc;

namespace LiteThinkingAugust.Controllers
{
    public class TransactionController : BaseController
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetTransactionsQuery();
            var result = await this.Mediator.Send(query);
            return this.FromResult(result);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(CreateTransactionCommandModel model)
        {
            var command = this.Mapper.Map<CreateTransactionCommand>(model);
            var result = await this.Mediator.Send(command);
            return this.FromResult(result);
        }
    }
}
