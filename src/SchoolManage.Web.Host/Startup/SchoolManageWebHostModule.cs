using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SchoolManage.Configuration;

namespace SchoolManage.Web.Host.Startup
{
    [DependsOn(
       typeof(SchoolManageWebCoreModule))]
    public class SchoolManageWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SchoolManageWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SchoolManageWebHostModule).GetAssembly());
        }
    }
}
