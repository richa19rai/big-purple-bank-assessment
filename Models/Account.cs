namespace BankAPI.Models
{
    public class Account
    {
        public string AccountId { get; set; }
        public string DisplayName { get; set; }
        public string AccountType { get; set; }
        public string AccountStatus { get; set; }
        public string Currency { get; set; }
        public string OpeningDate { get; set; }
        public decimal AvailableBalance { get; set; }
    }

    public class AccountResponse
    {
        public List<Account> Data { get; set; }
        public Links Links { get; set; }
        public Meta Meta { get; set; }
    }

    public class Links
    {
        public string Self { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
    }

    public class Meta
    {
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
    }
}