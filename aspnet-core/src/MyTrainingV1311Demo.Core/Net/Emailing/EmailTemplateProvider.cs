using Abp.Dependency;
using Abp.Extensions;
using Abp.IO.Extensions;
using Abp.MultiTenancy;
using Abp.Reflection.Extensions;
using MyTrainingV1311Demo.Url;
using System;
using System.Collections.Concurrent;
using System.Text;

namespace MyTrainingV1311Demo.Net.Emailing
{
    public class EmailTemplateProvider : IEmailTemplateProvider, ISingletonDependency
    {
        private readonly IWebUrlService _webUrlService;
        private readonly ITenantCache _tenantCache;
        private readonly ConcurrentDictionary<string, string> _defaultTemplates;

        public EmailTemplateProvider(IWebUrlService webUrlService, ITenantCache tenantCache)
        {
            _webUrlService = webUrlService;
            _tenantCache = tenantCache;
            _defaultTemplates = new ConcurrentDictionary<string, string>();
        }

        public string GetDefaultTemplate(int? tenantId)
        {
            var tenancyKey = tenantId.HasValue ? tenantId.Value.ToString() : "host";

            return _defaultTemplates.GetOrAdd(tenancyKey, key =>
            {
                using (var stream = typeof(EmailTemplateProvider).GetAssembly().GetManifestResourceStream("MyTrainingV1311Demo.Net.Emailing.EmailTemplates.default.html"))
                {
                    var bytes = stream.GetAllBytes();
                    var template = Encoding.UTF8.GetString(bytes, 3, bytes.Length - 3);
                    template = template.Replace("{THIS_YEAR}", DateTime.Now.Year.ToString());
                    template = template.Replace("{TWITTER_URL}", GetTwitterIconUrl());
                    return template.Replace("{EMAIL_LOGO_URL}", GetTenantLogoUrl(tenantId));
                }
            });
        }

        private string GetTenantLogoUrl(int? tenantId)
        {
            if (!tenantId.HasValue)
            {
                return _webUrlService.GetServerRootAddress().EnsureEndsWith('/') + "TenantCustomization/GetTenantLogo/light/png";
            }

            var tenant = _tenantCache.Get(tenantId.Value);

            return _webUrlService.GetServerRootAddress(tenant.TenancyName).EnsureEndsWith('/') 
                + "TenantCustomization/GetTenantLogo/light/" + tenantId.Value + "/svg";       
        }

        private string GetTwitterIconUrl()
        {
           return _webUrlService.GetServerRootAddress().EnsureEndsWith('/') + "Common/Images/twitter.svg";
        }
    }
}
