using FutureBankingDashboard.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Library.Interfaces
{
    public interface IRecommendationRepository
    {
        IEnumerable<RecommendationModel> GetRecommendations(int companyId);
        void AddRecommendation(RecommendationModel model);
    }
}