using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SchoolManage.Authorization;

namespace SchoolManage
{
    [DependsOn(
        typeof(SchoolManageCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SchoolManageApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SchoolManageAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SchoolManageApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
