using Abp.AspNetCore.Mvc.Authorization;
using MyTrainingV1311Demo.Authorization.Users.Profile;
using MyTrainingV1311Demo.Graphics;
using MyTrainingV1311Demo.Storage;

namespace MyTrainingV1311Demo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(
            ITempFileCacheManager tempFileCacheManager,
            IProfileAppService profileAppService,
            IImageValidator imageValidator) :
            base(tempFileCacheManager, profileAppService, imageValidator)
        {
        }
    }
}