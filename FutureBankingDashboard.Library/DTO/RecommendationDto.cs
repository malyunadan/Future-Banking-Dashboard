using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Library.DTO
{
    public class RecommendationDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Priority { get; set; }   // 1 = vigtigst
        public int CompanyId { get; set; }

    }
}