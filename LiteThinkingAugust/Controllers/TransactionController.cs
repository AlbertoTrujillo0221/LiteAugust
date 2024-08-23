using Microsoft.AspNetCore.Mvc;

namespace LiteThinkingAugust.Controllers
{
    public class TransactionController : BaseController
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            
        }
    }
}
