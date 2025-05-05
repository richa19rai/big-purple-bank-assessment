using Microsoft.AspNetCore.Mvc;
using BankingApi.Models;
using System.Collections.Generic;

namespace BankingApi.Controllers
{
    [Route("banking/accounts")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAccounts()
        {
            var accounts = new List<Account>
            {
                new Account
                {
                    AccountId = "12345",
                    DisplayName = "Primary Savings",
                    AccountType = "SAVINGS",
                    Balance = new Balance { Amount = "5000.00", Currency = "AUD" }
                },
                new Account
                {
                    AccountId = "67890",
                    DisplayName = "Checking Account",
                    AccountType = "CHECKING",
                    Balance = new Balance { Amount = "1500.00", Currency = "AUD" }
                }
            };

            var response = new { data = new { accounts } };
            return Ok(response);
        }
    }
}