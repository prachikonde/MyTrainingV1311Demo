using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyTrainingV1311Demo.Authorization.Permissions.Dto;

namespace MyTrainingV1311Demo.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
