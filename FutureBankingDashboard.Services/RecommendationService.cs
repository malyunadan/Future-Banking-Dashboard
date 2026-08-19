using FutureBankingDashboard.Library.DTO;
using FutureBankingDashboard.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Services
{
    public class RecommendationService : IRecommendationService
    {
        private readonly IRecommendationRepository _repo;
        private readonly IEconomyRepository _economyRepo;
        private readonly ISustainabilityRepository _sustainabilityRepo;

        public RecommendationService(
            IRecommendationRepository repo,
            IEconomyRepository economyRepo,
            ISustainabilityRepository sustainabilityRepo)
        {
            _repo = repo;
            _economyRepo = economyRepo;
            _sustainabilityRepo = sustainabilityRepo;
        }

        public IEnumerable<RecommendationDto> GenerateRecommendations(int companyId)
        {
            var economy = _economyRepo.GetEconomy(companyId);
            var sustainability = _sustainabilityRepo.GetSustainability(companyId);

            var list = new List<RecommendationDto>();

            if (economy != null && economy.Expenses > economy.Income)
            {
                list.Add(new RecommendationDto
                {
                    Text = "Reducér dine udgifter for at forbedre din økonomiske balance.",
                    Priority = 1
                });
            }

            if (sustainability != null && sustainability.Co2Score == "E")
            {
                list.Add(new RecommendationDto
                {
                    Text = "Investér i grøn energi for at forbedre din CO2-score.",
                    Priority = 2
                });
            }

            return list.OrderBy(r => r.Priority);
        }
    }
}