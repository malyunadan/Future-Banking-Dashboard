using FutureBankingDashboard.Library.Interfaces;
using FutureBankingDashboard.Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Infrastructure.Repositories
{
    public class EconomyRepository : IEconomyRepository
    {
        private readonly AppDbContext _context;

        public EconomyRepository(AppDbContext context)
        {
            _context = context;
        }

        public EconomyModel GetEconomy(int companyId) => _context.Economy
                .FirstOrDefault(e => e.CompanyId == companyId); /// fejl

        public void AddEconomy(EconomyModel model)
        {
            _context.Economy.Add(model);
            _context.SaveChanges();
        }

        public void UpdateEconomy(EconomyModel model)
        {
            _context.Economy.Update(model);
            _context.SaveChanges();
        }
    }
}

