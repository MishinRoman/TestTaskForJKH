using JsonDataParser.View.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace JsonDataParser.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public async Task<BalancesView> GetBalances(int id)
        {
            var balancesFromJson = Balances.GetJson().DeserializedBalances.Where(i => i.Account_id == id);
            return new BalancesView
            {
                Calculation = balancesFromJson.Sum(c => c.Calculation)
            };
        }
    }
}
