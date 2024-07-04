using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyTrainingV1311Demo.Sessions.Dto;

namespace MyTrainingV1311Demo.Models.Common
{
    [AutoMapFrom(typeof(TenantLoginInfoDto)),
     AutoMapTo(typeof(TenantLoginInfoDto))]
    public class TenantLoginInfoPersistanceModel : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}