using AdultsApi.Models;

namespace AdultsAPI.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string Password);
    }
}