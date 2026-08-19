using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Library.Models
{
    public class RecommendationModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Priority { get; set; }
        public int CompanyId { get; set; }

    }
}
