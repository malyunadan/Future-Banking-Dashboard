using FutureBankingDashboard.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Library.Interfaces
{
    public interface ISustainabilityRepository
    {
        SustainabilityModel GetSustainability(int companyId);
        void AddSustainability(SustainabilityModel model);
        void UpdateSustainability(SustainabilityModel model);
    }
}
