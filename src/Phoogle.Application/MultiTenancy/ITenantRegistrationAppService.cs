using System.Threading.Tasks;
using Abp.Application.Services;
using Phoogle.Editions.Dto;
using Phoogle.MultiTenancy.Dto;

namespace Phoogle.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}