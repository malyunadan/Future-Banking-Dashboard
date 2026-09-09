using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Library.DTO
{
    public class EconomyDto
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }

        // Fra databasen
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Balance { get; set; }

        // Beregninger fra service-laget
        public decimal BurnRate { get; set; }
        public decimal Runway { get; set; }
    }
}
