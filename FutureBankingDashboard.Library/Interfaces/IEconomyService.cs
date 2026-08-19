using FutureBankingDashboard.Library.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Library.Interfaces
{
public interface IEconomyService
    {
        EconomyDto GetEconomyData(int companyId);
    }
}