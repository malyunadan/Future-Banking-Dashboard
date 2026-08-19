using FutureBankingDashboard.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Library.Interfaces
{
    public interface IEconomyRepository
    {
        EconomyModel GetEconomy(int companyId);
        void AddEconomy(EconomyModel model);
        void UpdateEconomy(EconomyModel model);
    }
}
