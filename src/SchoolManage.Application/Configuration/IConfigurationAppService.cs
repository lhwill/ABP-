using System.Threading.Tasks;
using SchoolManage.Configuration.Dto;

namespace SchoolManage.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
