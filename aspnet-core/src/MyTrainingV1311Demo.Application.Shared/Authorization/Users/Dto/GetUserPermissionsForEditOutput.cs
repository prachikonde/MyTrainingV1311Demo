using System.Collections.Generic;
using MyTrainingV1311Demo.Authorization.Permissions.Dto;

namespace MyTrainingV1311Demo.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}