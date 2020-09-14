using System.Collections.Generic;
using SchoolManage.Roles.Dto;

namespace SchoolManage.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
