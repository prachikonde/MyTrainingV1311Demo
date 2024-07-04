using System.Collections.Generic;
using MyTrainingV1311Demo.Authorization.Users.Dto;
using MyTrainingV1311Demo.Dto;

namespace MyTrainingV1311Demo.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos, List<string> selectedColumns);
    }
}