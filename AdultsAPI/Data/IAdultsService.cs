using System.Collections.Generic;
using System.Threading.Tasks;
using AdultsApi.Models;

namespace AdultsAPI.Data
{
    public interface IAdultsService
    {
        Task<IList<Adult>> GetAdultsAsync();
        Task<Adult> AddAdultAsync(Adult adult);
        Task RemoveAdultAsync(int adultId);
        Task<Adult> UpdateAsync(Adult adult);
        Task<Job> GetJob(int id);
    }
}