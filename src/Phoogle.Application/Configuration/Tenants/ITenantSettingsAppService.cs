using System.Threading.Tasks;
using Abp.Application.Services;
using Phoogle.Configuration.Tenants.Dto;

namespace Phoogle.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
