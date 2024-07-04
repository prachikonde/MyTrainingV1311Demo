using Abp.Auditing;
using MyTrainingV1311Demo.Configuration.Dto;

namespace MyTrainingV1311Demo.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}