using Abp.AutoMapper;
using MyTrainingV1311Demo.Organizations.Dto;

namespace MyTrainingV1311Demo.Mobile.MAUI.Models.User
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}
