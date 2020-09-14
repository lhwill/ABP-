using Abp.AspNetCore.Mvc.ViewComponents;

namespace SchoolManage.Web.Views
{
    public abstract class SchoolManageViewComponent : AbpViewComponent
    {
        protected SchoolManageViewComponent()
        {
            LocalizationSourceName = SchoolManageConsts.LocalizationSourceName;
        }
    }
}
