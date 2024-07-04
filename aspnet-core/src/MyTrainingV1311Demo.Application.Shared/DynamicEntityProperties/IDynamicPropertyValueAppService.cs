using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using MyTrainingV1311Demo.DynamicEntityProperties.Dto;

namespace MyTrainingV1311Demo.DynamicEntityProperties
{
    public interface IDynamicPropertyValueAppService
    {
        Task<DynamicPropertyValueDto> Get(int id);

        Task<ListResultDto<DynamicPropertyValueDto>> GetAllValuesOfDynamicProperty(EntityDto input);

        Task Add(DynamicPropertyValueDto dto);

        Task Update(DynamicPropertyValueDto dto);

        Task Delete(int id);
    }
}
