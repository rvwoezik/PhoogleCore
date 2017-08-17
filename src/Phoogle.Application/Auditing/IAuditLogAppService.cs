using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Phoogle.Auditing.Dto;
using Phoogle.Dto;

namespace Phoogle.Auditing
{
    public interface IAuditLogAppService : IApplicationService
    {
        Task<PagedResultDto<AuditLogListDto>> GetAuditLogs(GetAuditLogsInput input);

        Task<FileDto> GetAuditLogsToExcel(GetAuditLogsInput input);
    }
}