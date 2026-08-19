using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Library.Models
{
    public class FundingModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ApplicationUrl { get; set; }
        public string RequiredCo2Score { get; set; }

    }
}
