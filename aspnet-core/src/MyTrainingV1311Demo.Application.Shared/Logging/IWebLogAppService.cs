using Abp.Application.Services;
using MyTrainingV1311Demo.Dto;
using MyTrainingV1311Demo.Logging.Dto;

namespace MyTrainingV1311Demo.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
