using System.Threading.Tasks;
using Abp.Application.Services;
using SchoolManage.Authorization.Accounts.Dto;

namespace SchoolManage.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
