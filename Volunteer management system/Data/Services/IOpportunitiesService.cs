using Volunteer_management_system.Models;

namespace Volunteer_management_system.Data.Services
{
    public interface IOpportunitiesService
    {
        Task<IEnumerable<Opportunities>> GetAll();
        Task <Opportunities> GetById(string id);  
        Task Add(Opportunities opportunity);
        
        Task <Opportunities> Update(string id, Opportunities newOpportunity);

        void Delete(string id);
    }
}
