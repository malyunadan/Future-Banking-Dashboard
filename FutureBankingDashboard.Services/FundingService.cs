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
                    Title = f.Title,
                    Description = f.Description,
                    ApplicationUrl = f.ApplicationUrl,
                    RequiredCo2Score = f.RequiredCo2Score,
                    IsRelevant = f.RequiredCo2Score == co2Score
                });
            }
        }
    }
