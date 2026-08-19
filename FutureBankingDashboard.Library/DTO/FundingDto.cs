using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Library.DTO
{
    public class FundingDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ApplicationUrl { get; set; }

        // Bruges til matchning
        public string RequiredCo2Score { get; set; }
        public bool IsRelevant { get; set; }            // Beregnes i service-laget
    }
}