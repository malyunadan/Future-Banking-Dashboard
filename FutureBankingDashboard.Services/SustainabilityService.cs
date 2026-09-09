using FutureBankingDashboard.Library.DTO;
using FutureBankingDashboard.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Services
{
    public class SustainabilityService : ISustainabilityService
    {
        private readonly ISustainabilityRepository _repo;

        public SustainabilityService(ISustainabilityRepository repo)
        {
            _repo = repo;
        }

        public SustainabilityDto GetSustainabilityData(int companyId)
        {
            var model = _repo.GetSustainability(companyId);

            if (model == null)
                return null;

            return new SustainabilityDto
            {
                Id = model.Id,
                CompanyId = model.CompanyId,
                Co2Score = model.Co2Score,
                MonthlyEmission = model.MonthlyEmission,
                GreenEnergyPercentage = model.GreenEnergiPercentage
            };
        }
    }
}
