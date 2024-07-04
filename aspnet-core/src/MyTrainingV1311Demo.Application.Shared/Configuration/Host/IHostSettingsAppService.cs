using System.Threading.Tasks;
using Abp.Application.Services;
using MyTrainingV1311Demo.Configuration.Host.Dto;

namespace MyTrainingV1311Demo.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
