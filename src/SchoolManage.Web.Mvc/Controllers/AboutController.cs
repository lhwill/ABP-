using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using SchoolManage.Controllers;

namespace SchoolManage.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : SchoolManageControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
