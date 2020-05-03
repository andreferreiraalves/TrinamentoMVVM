namespace SimpleTrader.Domain.Models
{
    public class AssertTransactions : DomainObject
    {
        public Account Account { get; set; }
        public bool IsPurchase { get; set; }
        public Stock Stock { get; set; }
        public int Share { get; set; }
    }
}
