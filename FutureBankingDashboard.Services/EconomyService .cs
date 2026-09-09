using FutureBankingDashboard.Library.DTO;
using FutureBankingDashboard.Library.Interfaces;

namespace FutureBankingDashboard.Services
{
    public class EconomyService : IEconomyService
    {
        private readonly IEconomyRepository _repo;

        public EconomyService(IEconomyRepository repo)
        {
            _repo = repo;
        }

        public EconomyDto GetEconomyData(int companyId)
        {
            var model = _repo.GetEconomy(companyId);

            if (model == null)
                return null;

            return new EconomyDto
            {
                Id = model.Id,
                CompanyId = model.CompanyId,
                Income = model.Income,
                Expenses = model.Expenses,
                Balance = model.Balance,

                // Beregninger fra service-laget
                BurnRate = model.Expenses,
                Runway = model.Expenses > 0 ? model.Balance / model.Expenses : 0
            };

        }
    }
}
