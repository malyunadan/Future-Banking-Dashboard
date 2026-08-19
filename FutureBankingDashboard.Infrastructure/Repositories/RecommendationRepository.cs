using FutureBankingDashboard.Library.Interfaces;
using FutureBankingDashboard.Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Infrastructure.Repositories
{
    public class RecommendationRepository : IRecommendationRepository
    {
        private readonly AppDbContext _context;

        public RecommendationRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<RecommendationModel> GetRecommendations(int companyId)
        {
            return _context.Recommendations
                .Where(r => r.CompanyId == companyId)
                .OrderBy(r => r.Priority)
                .ToList();
        }

        public void AddRecommendation(RecommendationModel model)
        {
            _context.Recommendations.Add(model);
            _context.SaveChanges();
        }
    }
}

