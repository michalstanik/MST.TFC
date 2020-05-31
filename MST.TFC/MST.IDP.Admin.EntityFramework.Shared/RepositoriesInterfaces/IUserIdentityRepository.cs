using System;
using System.Threading.Tasks;

namespace MST.IDP.Admin.EntityFramework.Shared.RepositoriesInterfaces
{
    public interface IUserIdentityRepository
    {
        Task<bool> PasswordChangeIsForced(string userId);
        Task ResetChangePasswordFlag(string userId);
    }
}
