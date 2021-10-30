using AdultsClient.Models;

namespace AdultsClient.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string Password);
    }
}