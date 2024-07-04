using System.Threading.Tasks;
using Abp.Application.Services;
using MyTrainingV1311Demo.Install.Dto;

namespace MyTrainingV1311Demo.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}