using System.Collections.Generic;
using MyTrainingV1311Demo.Authorization.Permissions.Dto;

namespace MyTrainingV1311Demo.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}