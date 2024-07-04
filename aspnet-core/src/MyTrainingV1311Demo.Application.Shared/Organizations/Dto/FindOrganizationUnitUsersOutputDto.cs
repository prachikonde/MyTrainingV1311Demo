using Abp.Application.Services.Dto;

namespace MyTrainingV1311Demo.Organizations.Dto
{
    public class FindOrganizationUnitUsersOutputDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string EmailAddress { get; set; }
    }
}