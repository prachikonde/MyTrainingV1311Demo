using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace MyTrainingV1311Demo.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
