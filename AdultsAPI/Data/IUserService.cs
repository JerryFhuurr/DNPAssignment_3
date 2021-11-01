using System.Threading.Tasks;
using AdultsApi.Models;

namespace AdultsAPI.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string password);
    }
}