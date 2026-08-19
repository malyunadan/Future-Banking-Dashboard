namespace FutureBankingDashboard.Library.Models
{
    public class EconomyModel
    {
        public int Id { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Balance { get; set; }
        public int CompanyId { get; set; }

    }
}
