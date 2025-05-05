using BankingApi.Data;
using BankingApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BankingApi.Controllers
{
    [Route("banking/accounts")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly BankingContext _context;

        public AccountsController(BankingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAccounts()
        {
            var accounts = await _context.Accounts.ToListAsync();

            var response = new AccountsResponse
            {
                data = new AccountsData
                {
                    accounts = accounts
                }
            };

            return Ok(response);
        }
    }
}
