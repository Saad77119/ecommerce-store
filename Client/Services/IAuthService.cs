using Estore.Shared.Models;
using System.Threading.Tasks;



namespace Estore.Client.Services
{
    public interface IAuthService
    {
        Task Login(LoginRequest loginRequest);
        Task Register(RegisterRequest registerRequest);
        Task Logout();
        Task<CurrentUser> CurrentUserInfo();
     
    }
}
