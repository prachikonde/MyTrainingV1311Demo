using Abp.Authorization;
using MyTrainingV1311Demo.Authorization.Roles;
using MyTrainingV1311Demo.Authorization.Users;

namespace MyTrainingV1311Demo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
