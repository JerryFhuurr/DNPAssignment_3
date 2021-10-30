using System.Collections.Generic;
using System.Threading.Tasks;
using AdultsClient.Models;

namespace AdultsClient.Data
{
    public interface IFamiliesService
    {
        Task<Adult> GetAsync(int id);
        Task<IList<Adult>> GetAdultsAsync();
        Task AddAdultAsync(Adult adult);
        Task   RemoveAdultAsync(int adultId);
        Task   UpdateAsync(Adult adult);
        
        /*void AddAdult(Adult adult);
        void RemoveAdult(int todoId);
        void Update(Adult todo);
        Adult Get(int id);*/
    }
}