using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Library.Models
{
    public class SustainabilityModel
    {
        public int Id { get; set; }
        public string Co2Score { get; set; } // A-E
        public decimal MonthlyEmission { get; set; }
        public int GreenEnergiPercentage { get; set; }
        public int CompanyId { get; set; }
    }
}
