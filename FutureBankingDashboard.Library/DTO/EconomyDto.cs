using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Library.DTO
{
    public class EconomyDto
    {
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Balance { get; set; }

        // Beregninger fra service-laget
        public decimal BurnRate { get; set; }
        public decimal Runway { get; set; }
    }
}
