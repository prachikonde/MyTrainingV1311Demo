using System.Threading.Tasks;
using MyTrainingV1311Demo.Sessions.Dto;

namespace MyTrainingV1311Demo.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
