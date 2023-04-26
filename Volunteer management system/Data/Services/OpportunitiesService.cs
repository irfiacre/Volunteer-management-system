using Microsoft.EntityFrameworkCore;
using Volunteer_management_system.Models;

namespace Volunteer_management_system.Data.Services
{
    public class OpportunitiesService : IOpportunitiesService
    {
        private readonly AppDBContext _dbContext;

        public OpportunitiesService(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Opportunities opportunity)
        {
           await _dbContext.Opportunities.AddAsync(opportunity); 
            await _dbContext.SaveChangesAsync();

        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Opportunities>> GetAll()
        {
            var result = await _dbContext.Opportunities.ToListAsync();
            return result; 
        }

        public async Task<Opportunities> GetById(string id)
        {
            var result = await _dbContext.Opportunities.FirstOrDefaultAsync(n => n.ID == id);
            return result;
        }

        public async Task<Opportunities> Update(string id, Opportunities newOpportunity)
        {
            _dbContext.Update(newOpportunity);
            await _dbContext.SaveChangesAsync();
            return newOpportunity;
        }
    }
}
