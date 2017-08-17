using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Phoogle.Caching.Dto;

namespace Phoogle.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}
