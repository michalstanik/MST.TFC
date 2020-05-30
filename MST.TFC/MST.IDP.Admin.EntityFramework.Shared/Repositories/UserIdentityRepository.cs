using Microsoft.AspNetCore.Http.Connections;
using Microsoft.EntityFrameworkCore;
using MST.IDP.Admin.EntityFramework.Shared.DbContexts;
using MST.IDP.Admin.EntityFramework.Shared.Entities.Identity;
using MST.IDP.Admin.EntityFramework.Shared.RepositoriesInterfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MST.IDP.Admin.EntityFramework.Shared.Repositories
{
    public class UserIdentityRepository : IUserIdentityRepository
    {
        private readonly AdminIdentityDbContext _context;

        public UserIdentityRepository(AdminIdentityDbContext context)
        {
            _context = context;
        }

        public async Task<bool> PasswordChangeIsForced(string userId)
        {
            var userResult = await RetrieveUserById(userId);
            if (userResult == null)
            {
                throw new InvalidOperationException();
            }
            return userResult.ForcedPasswordChange;
        }

        private async Task<UserIdentity> RetrieveUserById(string userId)
        {
            return await _context.Users.Where(u => u.Id == userId).FirstOrDefaultAsync();
        }
    }
}
