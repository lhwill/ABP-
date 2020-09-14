using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SchoolManage.EntityFrameworkCore;
using SchoolManage.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace SchoolManage.Web.Tests
{
    [DependsOn(
        typeof(SchoolManageWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SchoolManageWebTestModule : AbpModule
    {
        public SchoolManageWebTestModule(SchoolManageEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SchoolManageWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SchoolManageWebMvcModule).Assembly);
        }
    }
}