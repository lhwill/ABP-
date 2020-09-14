using System.Collections.Generic;
using SchoolManage.Roles.Dto;

namespace SchoolManage.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
