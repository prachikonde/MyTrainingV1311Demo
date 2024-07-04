using Microsoft.AspNetCore.Antiforgery;

namespace MyTrainingV1311Demo.Web.Controllers
{
    public class AntiForgeryController : MyTrainingV1311DemoControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
