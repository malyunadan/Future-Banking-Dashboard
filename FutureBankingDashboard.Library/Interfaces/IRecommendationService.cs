using FutureBankingDashboard.Library.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Library.Interfaces
{
    public interface IRecommendationService
    {
        IEnumerable<RecommendationDto> GenerateRecommendations(int companyId);
    }
}