using FutureBankingDashboard.Library.Interfaces;
using FutureBankingDashboard.Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Infrastructure.Repositories
{
    public class SustainabilityRepository : ISustainabilityRepository
    {
        private readonly AppDbContext _context;

        public SustainabilityRepository(AppDbContext context)
        {
            _context = context;
        }

        public SustainabilityModel GetSustainability(int companyId)
        {
            return _context.Sustainability
                .FirstOrDefault(s => s.CompanyId == companyId);
        }

        public void AddSustainability(SustainabilityModel model)
        {
            _context.Sustainability.Add(model);
            _context.SaveChanges();
        }

        public void UpdateSustainability(SustainabilityModel model)
        {
            _context.Sustainability.Update(model);
            _context.SaveChanges();
        }
    }
}
