using System.Threading.Tasks;

namespace MyTrainingV1311Demo.Web.OpenIddict.Claims
{
    public interface IAbpOpenIddictClaimsPrincipalHandler
    {
        Task HandleAsync(AbpOpenIddictClaimsPrincipalHandlerContext context);
    }
}