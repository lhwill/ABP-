using System.Threading.Tasks;
using Abp.Application.Services;
using SchoolManage.Sessions.Dto;

namespace SchoolManage.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
