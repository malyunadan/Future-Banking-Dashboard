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
                    Income = model.Income,
                    Expenses = model.Expenses,
                    Balance = model.Income - model.Expenses,
                    BurnRate = model.Expenses,
                    Runway = model.Income > 0 ? model.Income / model.Expenses : 0
                };
            }
        }
    }
