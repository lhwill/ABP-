using System.Collections.Generic;
using SchoolManage.Roles.Dto;

namespace SchoolManage.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}