using Abp.Authorization;
using SchoolManage.Authorization.Roles;
using SchoolManage.Authorization.Users;

namespace SchoolManage.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
