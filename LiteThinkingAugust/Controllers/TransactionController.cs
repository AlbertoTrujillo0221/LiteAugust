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
    }
}
