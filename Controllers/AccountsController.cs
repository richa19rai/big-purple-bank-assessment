using Microsoft.AspNetCore.Mvc;
using BankAPI.Models;

namespace BankAPI.Controllers
{
    [ApiController]
    [Route("banking/accounts")]
    public class AccountsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<AccountResponse> GetAccounts()
        {
            // In a real application, this would come from a database
            var accounts = new List<Account>
            {
                new Account 
                { 
                    AccountId = "12345678", 
                    DisplayName = "Everyday Savings", 
                    AccountType = "SAVINGS",
                    AccountStatus = "OPEN",
                    Currency = "AUD",
                    OpeningDate = "2020-01-01",
                    AvailableBalance = 1250.42m
                },
                new Account 
                { 
                    AccountId = "87654321", 
                    DisplayName = "Investment Account", 
                    AccountType = "INVESTMENT",
                    AccountStatus = "OPEN",
                    Currency = "AUD",
                    OpeningDate = "2019-05-20",
                    AvailableBalance = 15720.00m
                }
            };

            var response = new AccountResponse
            {
                Data = accounts,
                Links = new Links
                {
                    Self = "https://api.bigpurplebank.com/banking/accounts",
                    First = "https://api.bigpurplebank.com/banking/accounts?page=1",
                    Last = "https://api.bigpurplebank.com/banking/accounts?page=1"
                },
                Meta = new Meta
                {
                    TotalRecords = accounts.Count,
                    TotalPages = 1
                }
            };

            return Ok(response);
        }
    }
}