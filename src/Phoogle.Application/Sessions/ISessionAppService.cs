using System.Threading.Tasks;
using Abp.Application.Services;
using Phoogle.Sessions.Dto;

namespace Phoogle.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
