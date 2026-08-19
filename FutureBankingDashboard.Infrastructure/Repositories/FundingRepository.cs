using FutureBankingDashboard.Library.Interfaces;
using FutureBankingDashboard.Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Infrastructure.Repositories
{
    public class FundingRepository : IFundingRepository
    {
        private readonly AppDbContext _context;

        public FundingRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<FundingModel> GetAllFunding()
        {
            return _context.Funding.ToList();
        }

        public FundingModel GetFundingById(int id)
        {
            return _context.Funding.FirstOrDefault(f => f.Id == id);
        }

        public void AddFunding(FundingModel model)
        {
            _context.Funding.Add(model);
            _context.SaveChanges();
        }
    }
}

