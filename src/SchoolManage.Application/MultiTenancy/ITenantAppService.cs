using Abp.Application.Services;
using SchoolManage.MultiTenancy.Dto;

namespace SchoolManage.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

