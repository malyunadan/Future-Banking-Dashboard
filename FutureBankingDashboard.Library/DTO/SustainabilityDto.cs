using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Library.DTO
{
    public class SustainabilityDto
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Co2Score { get; set; }            // A–E
        public decimal MonthlyEmission { get; set; }    // kg/ton
        public int GreenEnergyPercentage { get; set; }  // %
    }
}