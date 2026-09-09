using System;
using FutureBankingDashboard.Library.DTO;
using FutureBankingDashboard.Library.Interfaces;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Services
{
    public class FundingService : IFundingService
    {
        private readonly IFundingRepository _repo;

        public FundingService(IFundingRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<FundingDto> GetRelevantFunding(string co2Score)
        {
            var allFunding = _repo.GetAllFunding();

            return allFunding.Select(f => new FundingDto
            {
                Id = f.Id,
                Title = f.Title,
                Description = f.Description,
                ApplicationUrl = f.ApplicationUrl,
                RequiredCo2Score = f.RequiredCo2Score,

                // Rigtig matchning: funding er relevant hvis virksomheden har
                // LIGE SÅ GOD eller BEDRE score end kravet
                IsRelevant = IsScoreRelevant(co2Score, f.RequiredCo2Score)
            });
        }

        private bool IsScoreRelevant(string companyScore, string requiredScore)
        {
            var scale = new List<string> { "A", "B", "C", "D", "E" };

            int companyIndex = scale.IndexOf(companyScore);
            int requiredIndex = scale.IndexOf(requiredScore);

            // Virksomheden er relevant hvis dens score er bedre eller lig med kravet
            return companyIndex <= requiredIndex;
        }
    }
}

