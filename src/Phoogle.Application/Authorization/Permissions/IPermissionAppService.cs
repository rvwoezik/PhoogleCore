using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Phoogle.Authorization.Permissions.Dto;

namespace Phoogle.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
