using System.Collections.Generic;
using Abp.Application.Services.Dto;
using MyTrainingV1311Demo.Editions.Dto;

namespace MyTrainingV1311Demo.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}