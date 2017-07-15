using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week01.Models.Data;

namespace Week01.Services
{
    public class MockSessionService : ISessionService
    {
        private static User mockUser = new User
        {
            Id = 1,
            NickName = "차니"
        };

        public async Task<User> GetUserAsync()
        {
            return mockUser;
        }

        public async Task LoginAsync(User user)
        {
            throw new NotImplementedException();
        }

        public async Task LogoutAsync()
        {
            throw new NotImplementedException();
        }
    }
}
