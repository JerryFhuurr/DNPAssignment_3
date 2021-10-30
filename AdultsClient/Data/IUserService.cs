using System.Threading.Tasks;
using AdultsClient.Models;

namespace AdultsClient.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string password);
    }
}