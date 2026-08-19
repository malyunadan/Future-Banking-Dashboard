using FutureBankingDashboard.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Library.Interfaces
{
    public interface IFundingRepository
    {
        IEnumerable<FundingModel> GetAllFunding();
        FundingModel GetFundingById(int id);
        void AddFunding(FundingModel model);
    }
}