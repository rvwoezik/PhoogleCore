using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Phoogle.Authorization.Users.Dto;

namespace Phoogle.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
