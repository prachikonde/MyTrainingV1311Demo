using Abp.AutoMapper;
using MyTrainingV1311Demo.Authorization.Users.Dto;

namespace MyTrainingV1311Demo.Mobile.MAUI.Models.User
{
    [AutoMapFrom(typeof(CreateOrUpdateUserInput))]
    public class UserCreateOrUpdateModel : CreateOrUpdateUserInput
    {

    }
}
