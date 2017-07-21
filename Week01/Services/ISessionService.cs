using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week01.Models.Data;

namespace Week01.Services
{
    public interface ISessionService
    {
        Task<User> GetUserAsync();
        Task LoginAsync(User user);
        Task LogoutAsync();

        bool IsLoggedIn { get; }
    }
}
