using System.Threading.Tasks;
using Abp.Configuration;

namespace Phoogle.Timing
{
    public interface ITimeZoneService
    {
        Task<string> GetDefaultTimezoneAsync(SettingScopes scope, int? tenantId);
    }
}
