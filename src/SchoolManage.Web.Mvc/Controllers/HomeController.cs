using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using SchoolManage.Controllers;

namespace SchoolManage.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SchoolManageControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
