using Abp.AutoMapper;
using MyTrainingV1311Demo.Authorization.Users.Dto;

namespace MyTrainingV1311Demo.Mobile.MAUI.Models.User
{
    [AutoMapFrom(typeof(UserListDto))]
    public class UserListModel : UserListDto
    {
        public string Photo { get; set; }

        public string FullName => Name + " " + Surname;
    }
}
