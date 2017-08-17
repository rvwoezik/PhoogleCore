using Abp.Application.Services;
using Phoogle.Dto;
using Phoogle.Logging.Dto;

namespace Phoogle.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
