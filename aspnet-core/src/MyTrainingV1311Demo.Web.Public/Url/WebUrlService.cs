using Abp.Dependency;
using MyTrainingV1311Demo.Configuration;
using MyTrainingV1311Demo.Url;
using MyTrainingV1311Demo.Web.Url;

namespace MyTrainingV1311Demo.Web.Public.Url
{
    public class WebUrlService : WebUrlServiceBase, IWebUrlService, ITransientDependency
    {
        public WebUrlService(
            IAppConfigurationAccessor appConfigurationAccessor) :
            base(appConfigurationAccessor)
        {
        }

        public override string WebSiteRootAddressFormatKey => "App:WebSiteRootAddress";

        public override string ServerRootAddressFormatKey => "App:AdminWebSiteRootAddress";
    }
}