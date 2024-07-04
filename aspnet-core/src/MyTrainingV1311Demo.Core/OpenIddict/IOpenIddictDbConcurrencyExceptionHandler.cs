using System.Threading.Tasks;
using Abp.Domain.Uow;

namespace MyTrainingV1311Demo.OpenIddict
{
    public interface IOpenIddictDbConcurrencyExceptionHandler
    {
        Task HandleAsync(AbpDbConcurrencyException exception);
    }
}