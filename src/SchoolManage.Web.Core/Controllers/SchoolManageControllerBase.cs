using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SchoolManage.Controllers
{
    public abstract class SchoolManageControllerBase: AbpController
    {
        protected SchoolManageControllerBase()
        {
            LocalizationSourceName = SchoolManageConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
