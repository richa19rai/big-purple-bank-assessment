namespace BankingApi.Models;
public class Account
{
    public string AccountId { get; set; }
    public string DisplayName { get; set; }
    public string AccountType { get; set; }
    public Balance Balance { get; set; }
}

public class Balance
{
    public string Amount { get; set; }
    public string Currency { get; set; }
}