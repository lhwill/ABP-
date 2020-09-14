using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace SchoolManage.Web.Views
{
    public abstract class SchoolManageRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected SchoolManageRazorPage()
        {
            LocalizationSourceName = SchoolManageConsts.LocalizationSourceName;
        }
    }
}
