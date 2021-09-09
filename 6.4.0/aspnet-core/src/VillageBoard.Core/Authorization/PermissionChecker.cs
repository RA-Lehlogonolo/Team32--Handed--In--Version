using Abp.Authorization;
using VillageBoard.Authorization.Roles;
using VillageBoard.Authorization.Users;

namespace VillageBoard.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
