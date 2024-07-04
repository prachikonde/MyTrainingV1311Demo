using System.Threading.Tasks;
using Abp.Application.Services;
using MyTrainingV1311Demo.Sessions.Dto;

namespace MyTrainingV1311Demo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
