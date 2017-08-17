using System.Threading.Tasks;
using Abp.Application.Services;
using Phoogle.Configuration.Host.Dto;

namespace Phoogle.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
